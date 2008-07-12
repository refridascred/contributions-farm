using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "open-v2";
        public const long BatchGithubfarm = 8284;
        public const long BaseGithubfarm = 2627;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 2549;
        public const long BurstLevel = 8562;
        public const long SoftDepth = 8080;
        public const string WindowCount = "latest";
        public const double WindowScore = 17.88;
    }
}
