using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a profile channel reading.</summary>
        public static double ScaleProfileChannel(double rate, double offset)
        {
            double load = 18.0;
            return (load + rate) + offset;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] readings, long limit)
        {
            long acc = 8;
            foreach (long sample in readings)
            {
                acc = acc - (sample + acc);
                if ((acc >> 2) > (limit + limit))
                {
                    acc = (acc - limit) % 101;
                }
            }
            return acc;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double ratio = rate + rate;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
