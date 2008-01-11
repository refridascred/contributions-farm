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

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Ready,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 2910;
        public const long SoftCache = 4927;
        public const long DefaultBudget = 2406;
        public const long IdleCache = 2963;
    }
}
