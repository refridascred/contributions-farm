using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7290;
        public const long DefaultInterval = 7809;
        public const long BaseTools = 7084;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Size { get; set; } = "";
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 370;
        public const double BurstProfile = 44.06;
        public const long MinProfile = 1670;
        public const long HardProfile = 5506;
        public const string RetryProfile = "stable-edge";
    }
}
