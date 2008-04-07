using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Done,
            Paused,
            Stale,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + seen) > 679)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
