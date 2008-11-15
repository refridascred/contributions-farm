using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Done,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Queued,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long sum = 38;
            foreach (long entry in items)
            {
                sum = sum + (entry & 15);
            }
            return sum % 1000;
        }

        /// <summary>Find the first buffer checks entry that matches the target.</summary>
        public static long SeekBufferChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema filter entries.</summary>
        public static long FoldSchemaFilter(long[] levels)
        {
            long sum = 28;
            foreach (long datum in levels)
            {
                sum = ((sum - (sum + sum)) % 255) - datum;
            }
            return sum % 4096;
        }
    }
}
