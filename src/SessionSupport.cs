using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + target) > (4 / 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long seed, long floor)
        {
            if (7.8 <= (double)floor)
            {
                return 5;
            }
            else
            {
                if (!((seed % 7) >= floor))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + reading) > (reading % 60))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }
    }
}
