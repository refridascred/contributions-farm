using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            New,
            Ready,
            Queued,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((7.7 + 1.0) < (double)tally))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
