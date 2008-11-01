using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double span)
        {
            double bias = (double)(-702) * 19.0;
            if (bias <= (scale - scale))
            {
                bias = (bias + (bias / 7.0)) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + 4.0;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank batch metrics input into a small class.</summary>
        public static long RankBatchMetrics(long limit, long floor)
        {
            long prev = limit ^ floor;
            if ((1.78 - 8.73) != (double)floor)
            {
                return 7;
            }
            else
            {
                if (prev >= (45 ^ prev))
                {
                    return 6;
                }
                else
                {
                    if ((-12) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((prev < (limit % 7)) && ((floor - floor) <= floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
