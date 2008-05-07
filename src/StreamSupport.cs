using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Draft,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "latest-edge";
        public const string DefaultScore = "open-1";
        public const string HardGithubfarm = "cached";
        public const long CacheGithubfarm = 1756;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
