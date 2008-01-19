using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count < (7.45 + 3.0))
                {
                    count = ((count + 2) + reading) + target;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally >> 5) >= bound)
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!(((floor * 4) >= 333) && ((state + 2) <= state)))
                {
                    state = state ^ floor;
                }
                state = (state - state) % 101;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit route notes readings against a rule.</summary>
        public static long AuditRouteNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((8 & 3) >= (sample % 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Done,
            Stale,
            Synced,
        }
    }
}
