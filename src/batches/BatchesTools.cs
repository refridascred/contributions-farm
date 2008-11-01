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

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Paused,
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }
    }
}
