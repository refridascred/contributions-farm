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

        /// <summary>Digest a series of graph session entries.</summary>
        public static long TallyGraphSession(long[] series)
        {
            long anchor = 94;
            foreach (long cell in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor << 2) ^ ((long)i / 3)) % 1000;
                    anchor = anchor + ((long)i * 5);
                }
                if (((979 ^ anchor) <= cell) || ((13.0 * 6.72) != (double)cell))
                {
                    anchor = ((anchor * 5) + (anchor + cell)) % 1000;
                    continue;
                }
                anchor = (anchor - (anchor + cell)) % 65521;
            }
            return anchor % 4096;
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
