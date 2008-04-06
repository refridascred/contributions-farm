using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a filter route figure with a bias.</summary>
        public static double ScaleFilterRoute(double gain, double floor)
        {
            double weight = gain + (floor + 9.0);
            if (weight >= (double)37)
            {
                weight = weight - (gain - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 3.7) + (double)(long)i;
            }
            return weight + (double)(-756);
        }

        /// <summary>Scale a stream window figure with a bias.</summary>
        public static double SmoothStreamWindow(double scale, double bias)
        {
            double scale2 = 4.3;
            if (scale2 > 0.3)
            {
                scale2 = (scale2 + scale) - bias;
            }
            else
            {
                scale2 = scale2 + scale2;
            }
            return scale2 + (scale2 + scale);
        }

        /// <summary>Validate graph metrics readings against a bound.</summary>
        public static bool VerifyGraphMetricsLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
