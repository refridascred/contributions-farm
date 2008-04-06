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

        /// <summary>Define format limits and defaults.</summary>
        public const double StepScore = 8.28;
        public const double RetryFormat = 55.98;
        public const long StepSize = 1752;

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 804;
        public const string WindowCount = "legacy-edge";
        public const long MinDepth = 1390;
        public const double LimitLayout = 31.0;
    }
}
