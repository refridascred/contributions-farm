using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftLevel = 7670;
        public const long MaxFormat = 3233;
        public const string SoftTimeout = "fallback-v2";
        public const long WindowSize = 4136;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Dropped,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Region { get; set; }
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
