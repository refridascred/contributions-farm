using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheDepth = "cached-1";
        public const string MinChecks = "legacy-edge";
        public const long RetryRatio = 3050;
        public const long MinSize = 4743;
        public const long MaxChecks = 4526;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
