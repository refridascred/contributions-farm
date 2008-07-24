using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long seed2)
        {
            long next = seed - seed2;
            if (((seed2 + seed) <= (seed * 2)) && ((next & 63) >= next))
            {
                return 6;
            }
            else
            {
                if ((seed2 * 3) != (next % 8))
                {
                    return 1;
                }
                else
                {
                    if ((3.77 - 8.5) >= (double)seed2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 79.87;
        public const long BaseInterval = 7794;
        public const long BatchEntry = 9731;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
