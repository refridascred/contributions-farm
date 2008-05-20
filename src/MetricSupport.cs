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

        /// <summary>Match up graph format samples.</summary>
        public static long OverlapGraphFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
