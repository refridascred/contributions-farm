using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "fallback-v2";
        public const string BurstWidth = "alpha-1";
        public const double WindowSize = 62.39;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Retry,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Pending,
            Active,
        }
    }
}
