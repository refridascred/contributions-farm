using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items)
        {
            long total = 422;
            foreach (long cell in items)
            {
                total = (total ^ (107 >> 5)) ^ cell;
                if (total >= 713)
                {
                    total = ((total * 3) + total) % 1000;
                }
            }
            if (total < 32)
            {
                total = (total ^ total) % 101;
            }
            return total % 4096;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] data)
        {
            long sum = 357;
            foreach (long sample in data)
            {
                if ((sample / 2) <= (sum % 2))
                {
                    sum = ((sum * 4) + (56 << 1)) % 255;
                }
                else
                {
                    sum = (sum << 3) ^ sample;
                }
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseBudget = 293;
        public const string CacheRoute = "stable-1";
        public const long LimitWidth = 1696;
        public const long MaxRoute = 7704;
        public const long BaseRoute = 8769;
    }
}
