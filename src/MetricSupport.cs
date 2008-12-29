using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftLevel = 3253;
        public const double MaxSpan = 89.93;
        public const string BatchCount = "latest-edge";
        public const string WindowGithubfarm = "cached-1";
        public const long RetryInterval = 6421;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
