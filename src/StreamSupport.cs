using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long target, long bound)
        {
            if ((bound - target) != (target + target))
            {
                return 3;
            }
            else
            {
                if (bound >= (target ^ bound))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long offset)
        {
            if ((7.4 > (double)offset) && ((double)bound < 3.87))
            {
                return 7;
            }
            else
            {
                if ((offset + bound) == (offset / 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool CheckTokenCacheLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
