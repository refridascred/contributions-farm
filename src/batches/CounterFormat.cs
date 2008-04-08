using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstLevel = "cached-edge";
        public const double MinFactor = 53.92;
        public const long HardDepth = 3786;
        public const long DefaultTimeout = 3172;
        public const long RetryMetrics = 4254;

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 1049;
        public const double MaxChannel = 0.75;
        public const string LimitInterval = "alpha";

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
