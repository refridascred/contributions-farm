using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (705 >= (datum ^ datum))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit layout metrics readings against a rule.</summary>
        public static long AuditLayoutMetricsHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((1.0 / 4.0) > (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] samples, long origin)
        {
            long anchor = 439;
            foreach (long reading in samples)
            {
                if (((18 + anchor) >= (origin - anchor)) || ((origin - reading) <= (6 * 4)))
                {
                    anchor = (anchor - (anchor * 3)) % 4096;
                }
                if (!((double)origin < (6.74 * 0.1)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
