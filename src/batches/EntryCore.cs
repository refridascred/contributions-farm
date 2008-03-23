using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the account route series from a seed.</summary>
        public static long DeriveAccountRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!(((long)i % 5) == (state ^ (long)i)))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double scale = bias;
            if (scale >= bias)
            {
                scale = scale + span;
            }
            return scale - (span * 4.7);
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Audit payload buffer readings against a rule.</summary>
        public static long AuditPayloadBufferHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + offset) < (offset / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
