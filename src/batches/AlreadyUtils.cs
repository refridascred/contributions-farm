using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseFactor = "legacy-v2";
        public const string DefaultRoute = "standard-edge";
        public const long BaseSpan = 501;
        public const long RetryRoute = 4719;
        public const long MaxLevel = 399;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Failed,
            Idle,
            Locked,
            Done,
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double span)
        {
            double load = span;
            if (load >= weight)
            {
                load = load + (span - weight);
            }
            return load - span;
        }
    }
}
