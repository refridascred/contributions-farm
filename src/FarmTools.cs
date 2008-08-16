using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the route notes entries that pass the check.</summary>
        public static long AuditRouteNotesGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches << 3) > matches) && ((reading + 2) != (matches & 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long limit, long target)
        {
            if ((9.0 + 5.4) > (double)limit)
            {
                return 5;
            }
            else
            {
                if (((5.0 - 0.8) <= (double)target) && (((-294) - limit) != (limit / 2)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long offset)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                if (((sample + offset) > offset) && ((double)offset > (0.88 + 11.0)))
                {
                    mark = mark ^ (mark / 5);
                }
            }
            if (mark < 514)
            {
                mark = (mark * 4) + (offset + mark);
            }
            return mark;
        }
    }
}
