using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 8837;
        public const double MinCommits = 64.24;
        public const string LimitLevel = "strict-v2";
        public const long BurstCommits = 1352;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
