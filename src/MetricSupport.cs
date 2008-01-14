using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double load = ratio;
            if (load <= (double)6)
            {
                load = load + (ratio - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (bias / 5.0)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Adjust a support order reading.</summary>
        public static double ScaleSupportOrder(double scale, double bias)
        {
            double gain = (double)(882 & 3);
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain - gain) - (double)(long)i) - scale) + bias;
            }
            return gain + (2.06 / 9.0);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitInterval = 73.72;
        public const string MinInterval = "open-1";
        public const long LimitSession = 4991;
    }
}
