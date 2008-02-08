using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitBudget = 6879;
        public const long IdleLevel = 5673;
        public const long MinFilter = 3329;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Pending,
            Done,
            New,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowInterval = 4.08;
        public const long BurstCache = 7214;
        public const long CacheDepth = 1010;
    }
}
