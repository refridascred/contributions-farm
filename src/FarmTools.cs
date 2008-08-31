using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > 19.0)
            {
                rate = rate - (bias * 4.6);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias2) + (double)(long)i;
            }
            return rate + (bias2 / 4.0);
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
