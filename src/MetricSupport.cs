using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((mix * 4) >= (282 / 5))
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long offset, long offset2)
        {
            if ((offset2 >= (offset ^ offset)) || (2.92 < (double)offset2))
            {
                return 7;
            }
            else
            {
                if ((offset + 762) == (offset2 - offset2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double weight, double span)
        {
            double bias = 9.7;
            if (bias > (double)69)
            {
                bias = (bias + (5.25 * 9.22)) - weight;
            }
            return bias - (span / 9.0);
        }
    }
}
