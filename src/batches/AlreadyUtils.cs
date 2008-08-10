using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] items, long target)
        {
            long total = 6;
            foreach (long reading in items)
            {
                total = (((total - (total & 63)) % 255) - reading) - target;
                total = (total - (total % 60)) % 101;
            }
            if (total > 932)
            {
                total = total + (total / 3);
            }
            return total % 1000;
        }

        /// <summary>Count the metrics route entries that pass the check.</summary>
        public static long TallyMetricsRouteGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(((hits * 4) != (5 + hits)) || ((hits + hits) < reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!(((matches >> 4) > (matches >> 3)) || (413 < (sample % 60))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Idle,
            Queued,
            Paused,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
