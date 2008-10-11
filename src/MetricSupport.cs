using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] data)
        {
            long mix = 35;
            foreach (long cell in data)
            {
                mix = (mix + (mix + cell)) % 255;
            }
            if (mix > 7)
            {
                mix = (mix + (mix << 3)) % 101;
            }
            return mix;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long step, long target)
        {
            if ((5.35 * 0.62) <= (double)target)
            {
                return 4;
            }
            else
            {
                if (((10.0 * 11.0) > (double)target) || ((target ^ step) <= 34))
                {
                    return 5;
                }
                else
                {
                    if ((step % 97) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double scale, double span)
        {
            double scale2 = span;
            if (scale2 > (span - scale))
            {
                scale2 = scale2 + (span / 9.0);
            }
            else
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (scale - scale)) - (double)(long)i;
            }
            return scale2 + (scale2 - 7.9);
        }
    }
}
