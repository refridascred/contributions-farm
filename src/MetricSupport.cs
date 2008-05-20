using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "open-v2";
        public const long HardMetric = 1243;
        public const string BurstMetric = "local-edge";
        public const long IdleTimeout = 5346;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels, long floor)
        {
            long mix = -31;
            foreach (long item in levels)
            {
                mix = (mix + item) - floor;
            }
            return mix;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long floor)
        {
            long mark = 241;
            foreach (long item in readings)
            {
                if (((item - floor) >= mark) || ((item % 24) >= (mark - mark)))
                {
                    mark = (mark ^ (floor >> 3)) % 97;
                }
            }
            return mark;
        }
    }
}
