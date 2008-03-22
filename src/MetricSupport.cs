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

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 7853;
        public const double LimitProfile = 47.69;
        public const long MaxProfile = 895;

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
