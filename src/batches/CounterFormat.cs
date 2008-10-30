using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double mean = (double)(3 >> 2);
            if (mean < (bias * 14.0))
            {
                mean = (mean + bias) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (double)84;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long floor)
        {
            if (((offset + offset) < floor) && ((double)floor == (double)7))
            {
                return 8;
            }
            else
            {
                if ((floor ^ floor) <= (offset << 2))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ (acc >> 2);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
