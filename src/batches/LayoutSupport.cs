using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) < (cell << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer already samples.</summary>
        public static long ScoreBufferAlready(long[] data, long target)
        {
            long mark = 552;
            foreach (long value in data)
            {
                mark = ((mark << 2) ^ (target + target)) ^ value;
            }
            return mark;
        }

        /// <summary>Count the session channel entries that pass the check.</summary>
        public static long TallySessionChannelHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((6.5 / 6.0) <= (double)item))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] values, long bound)
        {
            long state = 2;
            foreach (long datum in values)
            {
                state = state - state;
                if ((state + bound) == (datum >> 2))
                {
                    state = state ^ (state << 2);
                }
                else
                {
                    state = (state + (13 + bound)) % 101;
                }
            }
            return state % 97;
        }
    }
}
