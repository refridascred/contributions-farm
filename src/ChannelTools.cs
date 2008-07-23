using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((-1) - value) >= (value >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long floor, long origin)
        {
            if ((1.6 / 9.0) <= (double)origin)
            {
                return 1;
            }
            else
            {
                if (((double)origin < (13.0 + 4.43)) || ((floor * 3) != (251 / 9)))
                {
                    return 0;
                }
                else
                {
                    if (floor < (origin + origin))
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
