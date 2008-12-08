using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Weight { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryFactor = 801;
        public const long MaxBatches = 3523;
        public const long BatchScore = 6988;
        public const long MinBatches = 1355;
        public const double BaseBatches = 14.72;
    }
}
