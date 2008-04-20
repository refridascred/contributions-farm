using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftSpan = 2669;
        public const double MaxWidth = 90.67;
        public const long BurstGithubfarm = 7714;
        public const double MinGithubfarm = 48.43;
        public const double MaxSize = 43.07;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleRatio = "cached-1";
        public const long LimitWindow = 4321;
        public const long CacheCount = 6006;
    }
}
