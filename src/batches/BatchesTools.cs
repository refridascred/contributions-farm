using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7851;
        public const double CacheWidth = 34.21;
        public const long RetryWidth = 211;
        public const long MaxCommits = 3691;
        public const long BurstCommits = 7574;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            New,
            Done,
            Queued,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
