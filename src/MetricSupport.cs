using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinWidth = 47.96;
        public const double DefaultLevel = 64.23;
        public const long BurstRatio = 1790;

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
