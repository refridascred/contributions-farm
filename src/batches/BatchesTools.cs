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

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
