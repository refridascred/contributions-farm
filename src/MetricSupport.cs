using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            New,
            Failed,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
