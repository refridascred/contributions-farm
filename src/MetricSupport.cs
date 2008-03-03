using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] levels, long target)
        {
            long mark = 86;
            foreach (long entry in levels)
            {
                mark = ((mark + (mark % 64)) ^ entry) - target;
            }
            if (mark > 1)
            {
                mark = (mark ^ 13) % 1000;
            }
            return mark;
        }

        /// <summary>Audit cache cluster readings against a rule.</summary>
        public static long TallyCacheClusterGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((double)(long)samples.Length != (9.0 - 2.49)))
                {
                    seen = ((seen + 2) ^ value) - target;
                }
            }
            return seen;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double ratio, double bias)
        {
            double gain = (ratio + 2.7) / 7.0;
            if (gain > (double)33)
            {
                gain = (gain + (gain / 7.0)) - bias;
            }
            return gain + ratio;
        }
    }
}
