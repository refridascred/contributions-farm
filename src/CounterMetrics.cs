using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long limit)
        {
            long lane = origin + limit;
            if (5.92 >= (double)origin)
            {
                return 0;
            }
            else
            {
                if (!((426 % 3) < (limit - lane)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double gain = bias + bias;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + (gain + bias)) + (double)(long)i) + rate;
            }
            return gain - (bias * 9.6);
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double drift = (double)(927 ^ (-22));
            if (drift >= (ratio - ratio))
            {
                drift = drift + 5.54;
            }
            return drift - (bias + bias);
        }
    }
}
