using CarNS;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        Car testObject;
        int testGasTankSize;
        double testMpg;

        [TestInitialize]
        public void CreatCarObject()
        {
            testGasTankSize = 10; //Initial gas tank size
            testMpg = 50;

            testObject = new Car("dodge", "neon", testGasTankSize, testMpg);
        }
       
            //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
            [TestMethod]
            public void EmptyTest()
            {
                Assert.AreEqual(10, 10, .001);
            }
        
        //TODO: constructor sets gasTankLevel properly

        [TestMethod]
        public void TestInitialGasTank()
        {
            //int testInput = 13; //initial gas tank size
            //Car testObject = new Car("dodge", "neon", testInput, 20);

            double actualOutput = testObject.GasTankLevel;
            double expectedOutput = testGasTankSize;

            Assert.AreEqual(expectedOutput, actualOutput, .001);
            Assert.IsTrue(actualOutput == expectedOutput);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            //Drive 50 miles
            testObject.Drive(50);
            double actualOutput = testObject.GasTankLevel;
            //Verify GasTankLevel is set to the correct value after calling Drive(50)
            double expectedOutput = 9;
            Assert.AreEqual(expectedOutput, actualOutput, .001);
        }

        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        //miles = 100;

        public void TestGasTankAfterExceedingTankRange()
        {
            testObject.Drive(100);
            double actualOutput = testObject.GasTankLevel;
            double expectedOutput = 0;
            Assert.AreEqual(expectedOutput, actualOutput, .001);
        }


        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            testObject.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");

        }


    }
}
