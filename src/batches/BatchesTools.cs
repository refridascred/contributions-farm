using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultCount = 3722;
        public const long DefaultWidth = 1792;
        public const long BurstPayload = 5793;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
