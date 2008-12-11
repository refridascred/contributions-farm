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

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double rate, double offset)
        {
            double mean = offset - (offset * 16.0);
            if (mean >= (double)(-8))
            {
                mean = mean + rate;
            }
            else
            {
                mean = mean + (offset - rate);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + rate) - (double)(long)i;
            }
            return mean + (5.57 - rate);
        }
    }
}
