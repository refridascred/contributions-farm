using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + (bound & 31)) % 255;
                if ((state << 1) <= (state + bound))
                {
                    state = (state ^ bound) % 97;
                }
                if (((double)bound >= (double)state) || (bound > (130 << 2)))
                {
                    state = (state ^ (bound + (long)i)) % 65521;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate report cache readings against a bound.</summary>
        public static bool CheckReportCacheLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the graph format entries that pass the check.</summary>
        public static long TallyGraphFormatMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches * 5) != (entry >> 2))
                {
                    matches = (matches + 2) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
