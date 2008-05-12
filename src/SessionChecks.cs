using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long offset, long floor)
        {
            if (15.0 < (double)offset)
            {
                return 8;
            }
            else
            {
                if (((floor / 7) < floor) && ((double)offset <= (3.0 / 5.0)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the notes stats entries that pass the check.</summary>
        public static long TallyNotesStatsGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((value / 8) <= (value + seed)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
