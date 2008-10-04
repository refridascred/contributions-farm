using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string HardWidth = "standard-edge";
        public const long RetryFormat = 1556;
        public const long WindowFormat = 2508;

        /// <summary>Digest a series of order stats entries.</summary>
        public static long CombineOrderStats(long[] samples)
        {
            long acc = 79;
            foreach (long entry in samples)
            {
                if (!((double)acc > (1.0 + 15.0)))
                {
                    acc = ((acc * 3) + (entry + acc)) % 4096;
                }
                else
                {
                    acc = ((acc * 4) + (acc ^ entry)) % 1000;
                }
                if (acc >= (acc * 2))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseTimeout = 29.85;
        public const long BurstMetrics = 46;
        public const long HardLevel = 9032;
        public const string WindowDepth = "latest-v2";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(value >= floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
