using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the support token entries that pass the check.</summary>
        public static long CountSupportTokenOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - 97) < (2 - matches))
                {
                    matches = ((matches + 3) ^ entry) - seed;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a schema support sample.</summary>
        public static long LookupSchemaSupportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long offset, long limit)
        {
            long cur = offset - limit;
            if ((offset % 60) <= (offset + offset))
            {
                return 7;
            }
            else
            {
                if (((limit << 1) >= (cur % 7)) || ((limit + limit) == (limit + cur)))
                {
                    return 4;
                }
                else
                {
                    if (((12.0 - 5.0) < (double)cur) && ((limit / 6) >= (offset * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit > 7)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
