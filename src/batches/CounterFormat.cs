using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 4594;
        public const long SoftProfile = 6486;
        public const long IdleSize = 9695;
        public const string StepTimeout = "legacy";

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double load = 7.0;
            if (load > (2.67 + load))
            {
                load = load - bias;
            }
            else
            {
                load = load + (double)346;
            }
            return load + (bias + offset);
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
