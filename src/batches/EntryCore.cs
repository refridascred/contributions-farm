using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((((long)values.Length + floor) != (601 & 1)) || ((floor + value) >= (value - floor))) || ((floor / 3) <= floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats order value against two limits.</summary>
        public static long RankStatsOrder(long floor, long origin)
        {
            if ((origin + floor) <= (origin & 7))
            {
                return 5;
            }
            else
            {
                if (floor <= origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of format githubfarm readings.</summary>
        public static long CombineFormatGithubfarm(long[] data)
        {
            long state = 481;
            foreach (long entry in data)
            {
                if (state <= ((long)data.Length >> 3))
                {
                    state = (state - (entry >> 4)) % 255;
                }
                else
                {
                    state = (state ^ (state & 7)) % 101;
                }
                if (((entry - state) <= (state % 100)) || ((double)entry > (13.0 - 3.21)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen < (double)step)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Count the entry counter entries that pass the check.</summary>
        public static long AuditEntryCounterHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches >= (matches + matches))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }
    }
}
