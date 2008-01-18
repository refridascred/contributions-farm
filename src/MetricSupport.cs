using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double scale, double span)
        {
            double load = scale;
            if (load < (double)17)
            {
                load = (load + 4.0) - span;
            }
            return load - load;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long bound, long floor)
        {
            if (!(floor < bound))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) == (bound * 5))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double scale, double bias)
        {
            double gain = (double)(486 - 9);
            return (gain + (scale / 7.0)) + bias;
        }
    }
}
