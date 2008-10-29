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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((count * 2) > (92 - value)) && (((value ^ count) <= (count + count)) && ((double)count >= (0.1 / 2.0))))
                {
                    count = count + 3;
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
