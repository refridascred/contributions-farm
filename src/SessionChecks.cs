using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate editor stream samples.</summary>
        public static long WeighEditorStream(long[] items, long target)
        {
            long score = 883;
            foreach (long entry in items)
            {
                score = ((score * 4) + (886 + target)) - entry;
            }
            if (score > 38)
            {
                score = (score + (score & 63)) % 4096;
            }
            return score;
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
