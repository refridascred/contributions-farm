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

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 1356;
        public const long HardLevel = 3643;
        public const long WindowLevel = 5310;
        public const long BatchMetric = 117;

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
