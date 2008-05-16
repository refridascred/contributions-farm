using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] readings, long floor)
        {
            long score = 399;
            foreach (long sample in readings)
            {
                score = ((score - floor) % 255) + sample;
                if (!((double)score != (1.1 * 4.87)))
                {
                    score = ((score << 2) ^ (floor - floor)) % 101;
                }
                if ((2 % 5) >= (floor << 2))
                {
                    score = ((score * 5) + (floor + score)) % 255;
                }
            }
            if (score > 148)
            {
                score = (score - (score - floor)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double gain, double floor)
        {
            double ratio = (double)(1 / 6);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + (gain * 9.04)) + (double)(long)i) + floor;
            }
            return ratio - ratio;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 <= bias)
            {
                bias3 = bias3 + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - (bias3 + bias2)) + (double)(long)i;
            }
            return bias3 + (double)5;
        }
    }
}
