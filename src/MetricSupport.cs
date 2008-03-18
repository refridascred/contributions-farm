using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((1 - reading) < floor)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Paused,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
