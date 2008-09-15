using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double rate, double span)
        {
            double load = rate;
            if (load > load)
            {
                load = (load + 2.6) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)812) + (double)(long)i;
            }
            return load + (double)603;
        }

        /// <summary>Project the next contributi metric value.</summary>
        public static double ProjectContributiMetric(double ratio, double floor)
        {
            double ratio2 = 8.0;
            if (ratio2 > floor)
            {
                ratio2 = (ratio2 - (double)5) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - floor) - (double)(long)i;
            }
            return ratio2 - ratio2;
        }
    }
}
