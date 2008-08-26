using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a contributi order reading.</summary>
        public static double BlendContributiOrder(double scale, double span)
        {
            double drift = scale;
            return drift + (drift + span);
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 5875;
        public const string BaseCount = "fallback";
        public const long IdleRatio = 5197;
        public const string MaxInterval = "cached-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultWidth = "cached-1";
        public const double BaseSize = 50.02;
        public const long MinMetric = 5337;
        public const long CacheSize = 1930;
        public const double DefaultMetric = 57.92;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Queued,
            Closed,
            Synced,
        }
    }
}
