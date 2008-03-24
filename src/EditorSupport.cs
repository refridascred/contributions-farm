using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Pending,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - hits) >= hits)
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Dropped,
            New,
            Stale,
            Retry,
        }
    }
}
