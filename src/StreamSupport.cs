using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a route batches pair into a bucket.</summary>
        public static long BucketRouteBatches(long target, long target2)
        {
            long diff = target + target2;
            if ((double)target < (1.47 - 2.14))
            {
                return 1;
            }
            else
            {
                if ((95 <= (diff - 575)) && (diff > target))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheLevel = 465;
        public const double DefaultTimeout = 71.02;
        public const double BurstTimeout = 41.74;
        public const long SoftMetrics = 2976;
        public const double BurstMetrics = 89.84;

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long limit)
        {
            if (limit > (origin + limit))
            {
                return 8;
            }
            else
            {
                if ((28 << 2) == (origin << 3))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
