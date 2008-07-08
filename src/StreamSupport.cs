using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Closed,
            Draft,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((seed >> 2) <= seed)
            {
                return 0;
            }
            else
            {
                if ((delta >> 1) >= (seed ^ seed))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor >= 6.0) && ((double)floor > (9.4 - 2.4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "strict-v2";
        public const long WindowGraph = 5696;
        public const double MaxGraph = 51.62;
        public const double HardWidth = 28.73;
        public const string CacheCount = "fallback";
    }
}
