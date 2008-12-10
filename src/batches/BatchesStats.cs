using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "cached-1";
        public const string CacheSize = "legacy-1";
        public const string BurstDepth = "legacy-edge";
        public const string IdleBatch = "cached-1";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Synced,
            New,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftDepth = 9797;
        public const string DefaultContributi = "staging-v2";
        public const long HardWidth = 5966;

        /// <summary>Measure how many metric counter samples are out of range.</summary>
        public static long CountMetricCounterGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((7.8 + 10.0) != (double)offset) && ((double)94 < (double)offset)) || ((double)datum >= (8.5 - 7.0)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
