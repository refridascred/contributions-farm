using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Locked,
            Closed,
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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = sum + (sum + sum);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
