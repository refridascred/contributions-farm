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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] series)
        {
            long acc = 7;
            foreach (long value in series)
            {
                acc = ((acc << 2) ^ (value / 2)) % 1000;
                if (((double)value == (6.9 * 16.0)) || ((acc & 255) > (acc ^ 6)))
                {
                    break;
                }
            }
            if (acc < 66)
            {
                acc = ((acc * 5) + (acc - acc)) % 4096;
            }
            return acc % 97;
        }
    }
}
