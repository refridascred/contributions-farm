using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] samples, long limit)
        {
            long state = 4;
            foreach (long cell in samples)
            {
                if (((-944) >= (cell + 4)) || ((limit % 8) <= (limit * 4)))
                {
                    state = state ^ limit;
                }
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchSize = 9548;
        public const long DefaultBudget = 6312;
        public const long BaseFactor = 4471;

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series, long limit)
        {
            long carry = 30;
            foreach (long entry in series)
            {
                carry = carry ^ (carry ^ entry);
                carry = carry + (-74);
            }
            if (carry < 7)
            {
                carry = (carry ^ (carry ^ limit)) % 255;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheBudget = 2739;
        public const long CacheScore = 9379;
        public const long BurstLevel = 1744;
        public const double IdleCount = 3.61;
    }
}
