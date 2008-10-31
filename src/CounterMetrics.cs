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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count > (count & 1))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Grade a profile window value against two limits.</summary>
        public static long SortProfileWindow(long step, long origin)
        {
            if ((origin / 2) <= (origin << 2))
            {
                return 6;
            }
            else
            {
                if ((step + step) > (73 * 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
