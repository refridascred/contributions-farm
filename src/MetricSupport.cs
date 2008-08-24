using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 8767;
        public const string RetryScore = "local-edge";
        public const long StepSpan = 604;
        public const double MaxScore = 33.54;
        public const long BurstTimeout = 659;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public bool Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
