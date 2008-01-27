using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 1491;
        public const string IdleRatio = "open-edge";
        public const long MaxFactor = 2890;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepSpan = 65.04;
        public const long MinStats = 6070;
        public const long LimitStats = 9484;
    }
}
