using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a cluster support reading.</summary>
        public static double BlendClusterSupport(double weight, double bias)
        {
            double mean = (double)(3 + 5);
            if (mean > (double)785)
            {
                mean = mean + (bias + weight);
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - (double)84;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double rate, double bias)
        {
            double load = bias;
            if (load >= (rate - bias))
            {
                load = load + bias;
            }
            else
            {
                load = load + (1.9 * 13.0);
            }
            return load + (9.44 - 2.0);
        }
    }
}
