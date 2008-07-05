using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 9602;
        public const long CacheInterval = 6034;
        public const long BaseBudget = 3076;
        public const long MaxCommits = 4196;
    }
}
