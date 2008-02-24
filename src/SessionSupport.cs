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

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((0.9 / 9.0) != (double)hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
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
