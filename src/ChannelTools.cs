using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstTimeout = 5463;
        public const long MinLevel = 704;
        public const long LimitCommand = 9833;
        public const long DefaultFactor = 9118;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinRatio = 14.21;
        public const string MinCount = "latest-v2";
        public const double MaxGithubfarm = 90.35;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
