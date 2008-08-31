using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double ratio, double floor)
        {
            double gain = floor;
            if (gain > (double)66)
            {
                gain = gain + gain;
            }
            return gain + (ratio - floor);
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double scale, double bias)
        {
            double weight = bias;
            if (weight >= weight)
            {
                weight = (weight - weight) + scale;
            }
            return weight + 15.0;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
