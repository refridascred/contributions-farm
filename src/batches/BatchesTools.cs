using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many editor cache samples are out of range.</summary>
        public static long AuditEditorCacheOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count * 4) <= (target >> 1))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Dropped,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long sum = 700;
            foreach (long value in levels)
            {
                sum = ((sum << 2) ^ (34 >> 1)) ^ value;
            }
            return sum;
        }
    }
}
