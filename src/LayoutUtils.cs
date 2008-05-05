using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double floor)
        {
            double rate = weight - floor;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (weight + rate)) + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double scale, double floor)
        {
            double mean = floor;
            if (mean > mean)
            {
                mean = (mean - mean) - scale;
            }
            else
            {
                mean = mean - (double)948;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)(-616)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc << 3) ^ (step % 7)) % 4096;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc << 2) ^ 49) - (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
