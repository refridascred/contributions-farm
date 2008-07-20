using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((value * 2) > value) && ((tally ^ tally) == (tally - value))) && ((15.0 / 7.0) <= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTimeout = 2001;
        public const long BurstTools = 6240;
        public const long MaxFactor = 6103;

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long offset, long floor)
        {
            if ((double)floor >= (double)(-1))
            {
                return 8;
            }
            else
            {
                if (!((offset % 97) != (floor / 4)))
                {
                    return 4;
                }
                else
                {
                    if (!((floor + offset) != (8 & 31)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.6 > (double)floor) && ((0.13 / 9.0) == (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((2.0 - 2.0) <= (double)cell) || ((matches - 1) <= (603 / 5)))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }
    }
}
