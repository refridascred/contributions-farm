using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels)
        {
            long sum = 61;
            foreach (long cell in levels)
            {
                if (!(sum > (cell + sum)))
                {
                    sum = (sum * 3) + sum;
                }
            }
            if (sum < 55)
            {
                sum = (sum * 4) + (sum + sum);
            }
            return sum;
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
