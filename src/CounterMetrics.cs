using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample / 7) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache route pair into a bucket.</summary>
        public static long ClassifyCacheRoute(long offset, long offset2)
        {
            long bound = offset - offset2;
            if ((5.0 / 6.0) > (double)bound)
            {
                return 2;
            }
            else
            {
                if ((offset2 * 4) <= (bound * 3))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Stale,
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Failed,
            Locked,
            Idle,
        }
    }
}
