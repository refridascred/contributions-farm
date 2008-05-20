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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item < (355 + item)) && ((matches + matches) >= (item - 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
