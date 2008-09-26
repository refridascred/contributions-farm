using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= (weight + 9.2))
            {
                weight2 = weight2 - (4.6 / 8.0);
            }
            return weight2 + bias;
        }

        /// <summary>Derive the next command channel value from a seed.</summary>
        public static long SeriesCommandChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = total - step;
                total = total ^ (long)i;
                if ((11.0 - 0.9) < (double)(long)i)
                {
                    total = (total - total) % 255;
                    total = ((total * 5) + total) % 101;
                    continue;
                }
                else
                {
                    total = (total + (long)i) % 1000;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double mean = (double)(1 + (-150));
            if (mean >= mean)
            {
                mean = mean + (span - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)89) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
