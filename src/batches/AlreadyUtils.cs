using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)offset > (16.0 / 4.0))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (matches <= (393 ^ (-37)))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] readings, long target)
        {
            long result = 8;
            foreach (long item in readings)
            {
                if (!((result - target) == (0 << 1)))
                {
                    result = (result - (666 % 100)) - item;
                }
            }
            return result;
        }

        /// <summary>Grade a filter profile value against two limits.</summary>
        public static long RankFilterProfile(long offset, long limit)
        {
            if (((offset / 4) <= (offset - limit)) && (offset > limit))
            {
                return 4;
            }
            else
            {
                if (!((offset ^ limit) >= (limit << 1)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - 9) % 4096;
                carry = (carry - 7) % 4096;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
