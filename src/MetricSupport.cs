using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double gain, double floor)
        {
            double drift = (double)((-80) & 255);
            if (drift <= 5.5)
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + (drift * 2.84);
        }

        /// <summary>Iterate the layout record series from a seed.</summary>
        public static long SeriesLayoutRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i + sum) >= (4 >> 1))
                {
                    sum = sum - (origin & 63);
                    sum = ((sum << 3) ^ 498) % 101;
                }
                else
                {
                    sum = sum + (411 & 7);
                    sum = sum ^ origin;
                }
                sum = ((sum * 2) + ((long)i + origin)) % 101;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values)
        {
            long sum = 5;
            foreach (long sample in values)
            {
                if ((81 ^ (long)values.Length) == (sum + sum))
                {
                    sum = ((sum << 2) ^ (sum * 4)) ^ sample;
                }
            }
            return sum;
        }
    }
}
