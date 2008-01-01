using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3029;
        public const double IdleCommits = 80.57;
        public const long RetryDepth = 9634;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double drift = ratio / 4.0;
            return drift + offset;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Idle,
            Ready,
            Paused,
            Locked,
        }
    }
}
