using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits >= (double)entry)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long floor, long step)
        {
            long diff = floor + step;
            if ((5 & 1) != (47 + diff))
            {
                return 3;
            }
            else
            {
                if ((diff * 2) != (floor * 2))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }
    }
}
