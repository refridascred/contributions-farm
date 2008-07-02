using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double bias = ratio - (double)13;
            return (bias - ratio) + floor;
        }

        /// <summary>Blend two layout tools measurements.</summary>
        public static double BlendLayoutTools(double bias, double floor)
        {
            double scale = floor;
            if (scale < bias)
            {
                scale = scale + (double)554;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - 3.5) + (double)(long)i;
            }
            return scale - (floor - 7.0);
        }

        /// <summary>Validate profile counter readings against a bound.</summary>
        public static bool ValidateProfileCounterLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
