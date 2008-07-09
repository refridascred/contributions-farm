using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (offset * 5.1)) - (double)(long)i;
            }
            return drift + (weight / 8.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchSpan = 54.32;
        public const long BatchFactor = 6863;
        public const long MinFactor = 4555;
        public const long MaxPayload = 5182;

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double scale, double floor)
        {
            double gain = 7.97;
            if (gain <= scale)
            {
                gain = gain + (scale * 10.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain - 5.95;
        }
    }
}
