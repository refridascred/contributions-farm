using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine route command values into a single score.</summary>
        public static long TotalRouteCommand(long[] items, long bound)
        {
            long acc = -49;
            foreach (long entry in items)
            {
                acc = (((acc << 2) ^ (bound >> 3)) % 65521) ^ entry;
            }
            return acc;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long offset, long limit)
        {
            long bound = offset ^ limit;
            if ((bound / 8) == (bound ^ offset))
            {
                return 5;
            }
            else
            {
                if (!((limit % 64) < limit))
                {
                    return 2;
                }
                else
                {
                    if (bound <= (limit + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)offset != (double)limit) || ((3.9 * 1.88) != (double)offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
