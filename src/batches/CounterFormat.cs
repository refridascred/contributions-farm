using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxFactor = "primary-1";
        public const long DefaultDepth = 4503;
        public const long BaseSpan = 7489;
        public const long MaxMetrics = 7683;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((tally << 3) < (tally + tally)) || ((reading - tally) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 1129;
        public const string IdleSession = "standard-v2";
        public const string RetryFactor = "fallback-edge";
    }
}
