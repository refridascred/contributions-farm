using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Active,
            Paused,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double scale, double floor)
        {
            double drift = (double)(3 ^ 86);
            return ((drift - (double)7) + scale) + floor;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double ratio, double floor)
        {
            double gain = (floor + floor) - (floor + floor);
            return gain + ratio;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double weight = (floor / 8.0) * 6.33;
            if (weight >= (floor / 7.0))
            {
                weight = (weight + floor) + bias;
            }
            else
            {
                weight = weight - 16.0;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight / 8.0)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
