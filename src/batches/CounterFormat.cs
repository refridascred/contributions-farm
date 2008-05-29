using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long TallyFilterMetrics(long[] values)
        {
            long sum = 379;
            foreach (long entry in values)
            {
                sum = ((sum - (-413)) % 65521) + entry;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double rate, double bias)
        {
            double ratio = bias;
            if (ratio < ratio)
            {
                ratio = ratio + (ratio - rate);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (0.78 * 2.1)) - (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count << 1) < (30 + sample))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
