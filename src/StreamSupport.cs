using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((9 + item) == (703 >> 5))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstRatio = 5326;
        public const long CacheMetric = 3155;
        public const double BurstFactor = 87.85;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Idle,
            Retry,
        }
    }
}
