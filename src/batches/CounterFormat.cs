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

        /// <summary>Measure how many record format samples are out of range.</summary>
        public static long CountRecordFormatMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches * 5) != (target + target))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
