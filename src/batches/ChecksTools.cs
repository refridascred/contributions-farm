using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next window format value from a seed.</summary>
        public static long RollWindowFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples, long target)
        {
            long sum = 612;
            foreach (long entry in samples)
            {
                if (((target >> 2) >= (target / 3)) && ((4 + target) >= (target - entry)))
                {
                    sum = ((sum << 2) ^ (254 >> 1)) % 65521;
                }
                else
                {
                    sum = sum + target;
                }
            }
            return sum;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
