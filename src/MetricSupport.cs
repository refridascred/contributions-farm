using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a context format reading.</summary>
        public static double AdjustContextFormat(double bias, double span)
        {
            double mean = span;
            if (mean <= (span + span))
            {
                mean = mean + mean;
            }
            return mean + (5.3 - bias);
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double gain, double floor)
        {
            double bias = floor;
            if (bias >= (gain + gain))
            {
                bias = bias + (bias + 5.0);
            }
            else
            {
                bias = bias + (double)6;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - gain) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series, long offset)
        {
            long mark = 325;
            foreach (long entry in series)
            {
                mark = ((mark << 3) ^ (entry + mark)) % 1000;
                if (((double)offset <= (11.0 - 7.24)) || ((0.8 / 7.0) == (double)offset))
                {
                    mark = (mark ^ (offset * 3)) % 97;
                }
            }
            return mark;
        }
    }
}
