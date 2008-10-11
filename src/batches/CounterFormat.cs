using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Project the next context already value.</summary>
        public static double AdjustContextAlready(double bias, double floor)
        {
            double rate = floor;
            return (rate + floor) + bias;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double bias)
        {
            double load = gain;
            return (load - (double)165) + bias;
        }
    }
}
