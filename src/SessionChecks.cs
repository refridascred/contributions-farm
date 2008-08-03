using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next report profile value from a seed.</summary>
        public static long SeriesReportProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark << 3) ^ (target * 5)) % 255;
                if (3.6 >= (double)target)
                {
                    mark = ((mark * 2) + mark) % 101;
                }
                else
                {
                    mark = (mark * 2) + (mark * 3);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series)
        {
            long state = -35;
            foreach (long reading in series)
            {
                state = state + (reading ^ 421);
                state = (state ^ reading) % 1000;
            }
            if (state < 6)
            {
                state = state ^ (630 & 15);
            }
            return state % 97;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long bound)
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

        /// <summary>Count the cache format entries that pass the check.</summary>
        public static long AuditCacheFormatGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((((matches / 9) <= matches) || ((double)offset <= (3.12 + 0.3))) || (((7.6 * 7.5) >= (double)item) && ((17 + 46) == (item + offset))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
