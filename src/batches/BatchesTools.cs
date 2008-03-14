using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "primary";
        public const double CacheDepth = 1.71;
        public const double StepScore = 94.96;
        public const double RetryRatio = 39.68;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseRatio = 72.75;
        public const long DefaultWidth = 834;
        public const string CacheSchema = "staging";
        public const double BaseInterval = 13.83;
    }
}
