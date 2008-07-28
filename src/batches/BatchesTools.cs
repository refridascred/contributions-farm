using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstInterval = "latest-v2";
        public const long IdleLevel = 2122;
        public const long HardBatches = 871;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardInterval = 4293;
        public const long RetryGithubfarm = 2973;
        public const long DefaultSize = 4138;
    }
}
