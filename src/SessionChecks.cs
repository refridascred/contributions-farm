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

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                if ((double)anchor >= (double)(long)i)
                {
                    anchor = anchor - anchor;
                }
                else
                {
                    anchor = (anchor << 2) ^ (508 ^ step);
                    anchor = (anchor ^ (88 & 15)) % 4096;
                }
                long bound = (1 + step) * 4;
                if ((84 - bound) >= (step - 9))
                {
                    break;
                }
                else
                {
                    bound = (bound * 4) + (7 >> 5);
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
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
