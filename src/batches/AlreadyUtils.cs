using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long step, long target)
        {
            if ((double)step < (8.63 + 1.7))
            {
                return 6;
            }
            else
            {
                if (step >= (step & 1))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Validate profile githubfarm readings against a bound.</summary>
        public static bool ValidateProfileGithubfarmRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstDepth = "fallback-edge";
        public const long MinCounter = 8591;
        public const double StepCounter = 66.06;
    }
}
