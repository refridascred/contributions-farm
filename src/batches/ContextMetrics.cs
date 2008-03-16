using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two stream token measurements.</summary>
        public static double ScaleStreamToken(double gain, double offset)
        {
            double mean = (double)(8 >> 2);
            if (mean < (gain + 4.8))
            {
                mean = mean + (double)421;
            }
            else
            {
                mean = mean - (mean * 3.6);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)1) + (double)(long)i;
            }
            return mean - (mean + offset);
        }

        /// <summary>Rank record farm input into a small class.</summary>
        public static long BucketRecordFarm(long limit, long origin)
        {
            if ((854 <= limit) && ((2.0 * 6.7) >= (double)origin))
            {
                return 5;
            }
            else
            {
                if (0.02 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double rate, double floor)
        {
            double mean = 3.61;
            if (mean < (2.0 / 7.0))
            {
                mean = (mean + (4.69 * 1.67)) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (rate - 8.8)) + (double)(long)i;
            }
            return mean + 5.28;
        }

        /// <summary>Match up token counter samples.</summary>
        public static long CompareTokenCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
