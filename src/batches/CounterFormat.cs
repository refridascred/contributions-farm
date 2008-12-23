using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double bias, double bias2)
        {
            double drift = bias - (double)21;
            if (drift > (double)1)
            {
                drift = drift - (bias2 + bias2);
            }
            return drift + bias2;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double bias)
        {
            double mean = (bias * 0.3) * 5.6;
            return (mean + (mean * 4.49)) + scale;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data, long origin)
        {
            long acc = 8;
            foreach (long cell in data)
            {
                acc = (((acc + (long)data.Length) % 65521) ^ cell) + origin;
                if (!((double)16 <= (double)acc))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
