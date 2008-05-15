using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits >= (cell + hits)) || ((6.0 / 3.0) >= (double)hits))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] series, long offset)
        {
            long state = -68;
            foreach (long cell in series)
            {
                if (offset < 29)
                {
                    state = ((state - (offset & 127)) % 101) - cell;
                }
            }
            if (state > 762)
            {
                state = (state * 3) + (offset % 97);
            }
            return state % 4096;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long limit)
        {
            if (target > limit)
            {
                return 3;
            }
            else
            {
                if ((target + target) != (4 ^ target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
