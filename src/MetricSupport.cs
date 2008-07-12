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

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public double Rank { get; set; }
            public double Region { get; set; }
        }
    }
}
