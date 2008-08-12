using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardWidth = 6445;
        public const double MaxGithubfarm = 64.4;
        public const string MinDepth = "legacy-v2";
        public const double IdleFactor = 40.96;

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 2169;
        public const long CacheRoute = 3388;
        public const double BurstRatio = 86.37;
        public const long MaxInterval = 195;
    }
}
