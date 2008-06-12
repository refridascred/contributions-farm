using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseDepth = 2031;
        public const string MinBudget = "standard-1";
        public const string CacheMetrics = "latest";

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
