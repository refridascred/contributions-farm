using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit counter checks readings against a rule.</summary>
        public static long TallyCounterChecksGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally & 127) < ((long)data.Length - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] series, long step)
        {
            long state = 259;
            foreach (long item in series)
            {
                if (((7.0 - 3.2) < (double)state) && ((step + 83) > item))
                {
                    state = state + (step + step);
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many commits route samples are out of range.</summary>
        public static long CountCommitsRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((reading - 4) < reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
