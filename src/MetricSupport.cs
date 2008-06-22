using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long offset, long target)
        {
            long prev = offset + target;
            if (((-1) + 59) >= (prev + prev))
            {
                return 3;
            }
            else
            {
                if ((double)target <= (0.3 * 8.14))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Closed,
            Draft,
            Queued,
        }
    }
}
