using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchInterval = 2684;
        public const double CacheMetric = 98.99;
        public const string WindowRatio = "stable-1";
        public const long BatchWidth = 6462;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstDepth = 6059;
        public const double MinScore = 23.33;
        public const string BatchChannel = "standard-v2";
        public const long RetryChannel = 2362;
        public const long IdleChannel = 7613;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + tally) >= tally)
                {
                    tally = ((tally + 2) ^ sample) + limit;
                }
            }
            return tally;
        }
    }
}
