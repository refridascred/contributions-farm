using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Stale,
            Locked,
            Pending,
        }

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
        public const string SoftFactor = "alpha-v2";
        public const long CacheWidth = 3556;
        public const double IdleCache = 10.67;
    }
}
