using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinInterval = 9818;
        public const long RetryLevel = 3144;
        public const string BaseTimeout = "latest-1";
        public const long CacheCluster = 3221;
        public const long DefaultCluster = 4748;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 54.4;
        public const long BaseRatio = 6035;
        public const long LimitGithubfarm = 689;
        public const long RetryGithubfarm = 377;
    }
}
