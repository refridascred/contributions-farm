using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Closed,
            Active,
            Done,
            New,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long AuditReportCounterMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (8.45 - 2.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
