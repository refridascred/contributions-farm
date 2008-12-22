using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((10.0 * 9.19) > (double)item)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Retry,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryBudget = 5971;
        public const string BaseGithubfarm = "fallback-1";
        public const long HardFactor = 873;
    }
}
