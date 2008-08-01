using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheDepth = 5739;
        public const double StepFactor = 38.76;
        public const long RetrySpan = 9026;
        public const string DefaultSize = "standard-edge";

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Queued,
            Locked,
        }
    }
}
