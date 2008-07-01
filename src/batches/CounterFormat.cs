using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((54 * 5) >= (tally - origin))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long origin, long offset)
        {
            if ((offset + offset) < (offset >> 5))
            {
                return 8;
            }
            else
            {
                if (((origin - origin) > offset) || (4.0 > (double)origin))
                {
                    return 0;
                }
                else
                {
                    if (!(origin > (origin << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin & 63) <= origin) && (7.2 > (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
