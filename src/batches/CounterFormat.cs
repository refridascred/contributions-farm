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

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double bias)
        {
            double load = gain;
            return (load - (double)165) + bias;
        }
    }
}
