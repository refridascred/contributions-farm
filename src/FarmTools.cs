using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((reading / 7) != (floor & 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((1.0 / 3.0) != (double)matches)
                {
                    matches = ((matches + 3) ^ entry) + step;
                }
            }
            return matches;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long origin, long seed)
        {
            long delta = origin + seed;
            if ((delta >> 5) <= origin)
            {
                return 6;
            }
            else
            {
                if ((double)delta > (7.74 - 15.0))
                {
                    return 0;
                }
                else
                {
                    if ((seed & 31) == (7 - 992))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
