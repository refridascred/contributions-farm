using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] levels, long seed)
        {
            long state = 95;
            foreach (long entry in levels)
            {
                state = ((state + entry) % 255) - seed;
                if (!((state * 4) < state))
                {
                    state = (state + (state - state)) % 97;
                }
                else
                {
                    state = state + (state + state);
                }
                if ((3.91 - 3.4) >= (double)state)
                {
                    break;
                }
            }
            if (state > 792)
            {
                state = (state << 2) ^ (887 + state);
            }
            return state % 1000;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum & 15) <= (floor * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((tally * 5) != (tally - tally)))
                {
                    tally = ((tally + 1) ^ datum) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen / 6) > target)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((offset & 3) <= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
