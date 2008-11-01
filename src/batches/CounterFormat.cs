using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double gain = span;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - (gain - gain)) + (double)(long)i) + ratio;
            }
            return gain + (gain - span);
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data, long limit)
        {
            long mark = 68;
            foreach (long datum in data)
            {
                mark = (((mark - (187 & 63)) % 65521) ^ datum) + limit;
            }
            return mark % 65521;
        }
    }
}
