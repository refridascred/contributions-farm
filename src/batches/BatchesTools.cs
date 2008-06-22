using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 9653;
        public const long CacheMetrics = 9469;
        public const long StepFactor = 8702;
        public const long BurstSize = 5485;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftWidth = "fallback";
        public const string HardWidth = "latest-1";
        public const string WindowSpan = "stable-v2";
        public const long MaxCluster = 4382;
    }
}
