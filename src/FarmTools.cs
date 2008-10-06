using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "alpha";
        public const string MinWidth = "cached-v2";
        public const long MaxProfile = 880;
        public const long CacheCount = 2124;
        public const long BurstProfile = 7867;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Closed,
            Pending,
            Paused,
            Locked,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Active,
            Synced,
            Ready,
            Idle,
        }
    }
}
