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

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] levels, long target)
        {
            long score = 383;
            foreach (long datum in levels)
            {
                if (((datum + 368) == (809 + datum)) || ((double)datum <= 0.53))
                {
                    score = score ^ (score - datum);
                }
                else
                {
                    score = ((score * 5) + (target + target)) % 1000;
                }
            }
            return score % 97;
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
