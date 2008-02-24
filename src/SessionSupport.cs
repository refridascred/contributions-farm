using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many notes record samples are out of range.</summary>
        public static long CountNotesRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((8.6 * 2.6) == (double)matches)
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series, long floor)
        {
            long result = 11;
            foreach (long datum in series)
            {
                result = (result + (floor >> 3)) + datum;
            }
            return result;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long origin, long target)
        {
            if ((0.2 > (double)target) && ((double)origin <= (5.82 / 8.0)))
            {
                return 7;
            }
            else
            {
                if ((9 >> 1) <= (678 + origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin * 2) <= (origin & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
