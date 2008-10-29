using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long offset, long limit)
        {
            if (((98 % 16) != (offset - offset)) && ((double)limit > (19.0 + 6.0)))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) >= 959)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many stats account samples are out of range.</summary>
        public static long CountStatsAccountGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((16 - count) >= (entry / 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (limit > (limit + matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
