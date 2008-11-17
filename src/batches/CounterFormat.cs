using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of counter context entries.</summary>
        public static long DigestCounterContext(long[] data)
        {
            long mark = 0;
            foreach (long sample in data)
            {
                if (mark < (968 + 902))
                {
                    mark = ((mark << 3) ^ (sample << 3)) % 101;
                }
            }
            if (mark < 16)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long offset, long limit)
        {
            if ((double)2 < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((4.52 * 0.7) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (!((7 + limit) > (limit * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double drift = (double)(4 & 3);
            if (drift > gain)
            {
                drift = drift + (double)337;
            }
            else
            {
                drift = drift + (double)0;
            }
            return drift + (floor * 1.2);
        }
    }
}
