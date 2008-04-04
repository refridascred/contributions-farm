using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Stale,
            Done,
            Locked,
            Active,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the filter buffer entries that pass the check.</summary>
        public static long AuditFilterBufferHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((double)reading == (7.61 / 7.0)) || ((double)reading < (9.8 + 20.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Closed,
            Done,
            Active,
            Retry,
        }
    }
}
