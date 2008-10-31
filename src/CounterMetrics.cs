using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits * 4) != (entry - hits)) || ((hits + entry) <= (entry << 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Done,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
