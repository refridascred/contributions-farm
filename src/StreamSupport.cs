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

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Limit { get; set; }
            public double Stamp { get; set; }
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
