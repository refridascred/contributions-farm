using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double bias = (double)(52 + 291);
            if (bias >= span)
            {
                bias = (bias + (span + span)) - weight;
            }
            return bias - (double)0;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Draft,
            New,
            Locked,
            Dropped,
        }

        /// <summary>Classify a metrics layout pair into a bucket.</summary>
        public static long RankMetricsLayout(long offset, long seed)
        {
            long cur = offset + seed;
            if (seed > (offset & 3))
            {
                return 6;
            }
            else
            {
                if ((seed % 24) <= (cur + offset))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum << 2) ^ sum;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double gain2 = 8.47 * 11.0;
            if (gain2 >= (gain2 + gain))
            {
                gain2 = gain2 - (gain2 * 0.7);
            }
            else
            {
                gain2 = gain2 + (6.39 / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - bias) + (double)(long)i;
            }
            return gain2 - gain2;
        }
    }
}
