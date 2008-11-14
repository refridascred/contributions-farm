using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Active,
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 57.92;
        public const long HardScore = 4324;
        public const double BatchCount = 67.04;

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double rate, double span)
        {
            double ratio = span;
            return (ratio - (span + 3.6)) + rate;
        }
    }
}
