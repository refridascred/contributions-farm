using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string CacheDepth = "stable";
        public const string WindowLevel = "primary-1";
        public const long RetryDepth = 4327;
        public const string BaseGithubfarm = "cached-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheScore = 8824;
        public const long BurstBuffer = 3672;
        public const long BaseTimeout = 1112;
        public const long HardTimeout = 5862;
        public const string WindowCount = "stable";

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Active,
            Pending,
            New,
            Dropped,
        }
    }
}
