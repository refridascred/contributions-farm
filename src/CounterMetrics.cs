using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((183 >> 2) > (bound - item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] levels, long offset)
        {
            long total = 177;
            foreach (long item in levels)
            {
                total = (total + total) + item;
                if ((offset - total) != (3 * 3))
                {
                    total = total ^ (total ^ total);
                }
            }
            return total % 65521;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double scale, double bias)
        {
            double scale2 = scale * 2.41;
            if (scale2 >= (double)807)
            {
                scale2 = scale2 + (double)3;
            }
            else
            {
                scale2 = scale2 - 0.2;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + bias) + (double)(long)i;
            }
            return scale2 - (scale2 + scale);
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long step, long limit)
        {
            if ((double)limit < (1.9 + 8.9))
            {
                return 5;
            }
            else
            {
                if (!((limit + (-66)) >= (step ^ limit)))
                {
                    return 0;
                }
                else
                {
                    if ((12.0 / 4.0) >= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
