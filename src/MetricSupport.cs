using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two command schema measurements.</summary>
        public static double BlendCommandSchema(double bias, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (2.3 / 8.0)) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Adjust a filter report reading.</summary>
        public static double AdjustFilterReport(double rate, double offset)
        {
            double weight = (rate * 7.4) / 5.0;
            if (weight < (rate + weight))
            {
                weight = (weight - (4.9 + weight)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - 10.0) - (double)(long)i;
            }
            return weight - (rate * 1.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 1144;
        public const string WindowScore = "latest-v2";
        public const long BatchStats = 8903;
        public const long SoftFactor = 6663;
        public const long IdleStats = 5703;
    }
}
