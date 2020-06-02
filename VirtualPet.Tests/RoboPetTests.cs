﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class RoboPetTests
    {
        private RoboPet testRoboPet;
        private object random;

        [Fact]
        public void RoboPet_Should_Have_Fuel()
        {
            Assert.NotNull(testRoboPet.Fuel);
        }

        [Fact]
        public void GetFuel_Should_Return_Initial_Fuel_Level_Of_50()
        {
            int testRoboPetFuel = testRoboPet.GetFuel();

            Assert.Equal(50, testRoboPetFuel);
        }

        [Fact]
        public void RoboPet_Should_Have_Oil()
        {
            Assert.NotNull(testRoboPet.Oil);
        }

        [Fact]
        public void GetOil_Should_Return_Initial_Oil_Level_Of_60()
        {
            int testRoboPetOil = testRoboPet.GetOil();

            Assert.Equal(60, testRoboPetOil);
        }

        [Fact]
        public void RoboPet_Should_Have_Grease()
        {
            Assert.NotNull(testRoboPet.Grease);
        }

        [Fact]
        public void GetGrease_Should_Return_Initial_Grease_Level_Of_60()
        {
            int testRoboPetGrease = testRoboPet.GetGrease();

            Assert.Equal(60, testRoboPetGrease);
        }

        [Fact]
        public void RoboPet_Should_Have_RoboHealth()
        {
            Assert.NotNull(testRoboPet.RoboHealth);
        }

        [Fact]
        public void GetRoboHealth_Should_Return_Initial_RoboHealth_Level_Of_50()
        {
            int testRoboPetRoboHealth = testRoboPet.GetRoboHealth();

            Assert.Equal(50, testRoboPetRoboHealth);
        }


        [Fact]
        public void FuelUp_Should_Increase_Fuel_By_40()
        {
            testRoboPet.FuelUp();

            Assert.Equal(40, testRoboPet.GetFuel());
        }

        [Fact]
        public void TopOffFluids_Should_Increase_Oil_By_40_()
        {
            testRoboPet.TopOffFluids();

            Assert.Equal(40, testRoboPet.GetOil());
        }

        [Fact]
        public void TopOffFluids_Should_Increase_Grease_By_40_()
        {
            testRoboPet.TopOffFluids();

            Assert.Equal(40, testRoboPet.GetGrease());
        }

        [Fact]
        public void TopOffFluids_Should_Increase_HydraulicFluid_By_40_()
        {
            testRoboPet.TopOffFluids();

            Assert.Equal(40, testRoboPet.GetHydraulicFluid());
        }

        [Fact]
        public void Take_To_Mechanic_Should_Increase_RoboHealth_By_40()
        {
            testRoboPet.Play();

            Assert.Equal(40, testRoboPet.GetRoboHealth());
        }

        [Fact]
        public void RunRoboPet_Should_Increase_RoboHealth_By_10()
        {
            testRoboPet.RunRoboPet();

            Assert.Equal(10, testRoboPet.GetRoboHealth());
        }


        [Fact]
        public void RunRoboPet_Should_Decrease_Fuel_By_20()
        {
            testRoboPet.RunRoboPet();

            Assert.Equal(20, testRoboPet.GetFuel());
        }

        [Fact]
        public void RunRoboPet_Should_Decrease_Oil_By_10()
        {
            testRoboPet.RunRoboPet();

            Assert.Equal(10, testRoboPet.GetOil());
        }

        [Fact]
        public void RunRoboPet_Should_Decrease_Grease_By_10()
        {
            testRoboPet.RunRoboPet();

            Assert.Equal(10, testRoboPet.GetGrease());
        }

        [Fact]
        public void RunRoboPet_Should_Decrease_HydraulicFluid_By_10()
        {
            testRoboPet.RunRoboPet();

            Assert.Equal(10, testRoboPet.GetHydraulicFluid());
        }

        [Fact]
        public void Robo_Tick_Should_Decrease_Oil_By_Random()
        {
            testRoboPet.Tick();

            Assert.Equal(random, testRoboPet.GetOil());
        }

        [Fact]
        public void Robo_Tick_Should_Decrease_Grease_By_Random()
        {
            testRoboPet.Tick();

            Assert.Equal(random, testRoboPet.GetGrease());
        }

        [Fact]
        public void Robo_Tick_Should_Decrease_HydraulicFluid_By_Random()
        {
            testRoboPet.Tick();

            Assert.Equal(random, testRoboPet.GetHydraulicFluid());
        }

    }
}
