using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitInterval = 94.03;
        public const long BatchCache = 9993;
        public const double StepFactor = 88.87;
        public const string StepCache = "cached-edge";

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double gain, double span)
        {
            double ratio = (double)(784 + 9);
            if (ratio >= (gain * 4.5))
            {
                ratio = (ratio + (ratio / 5.0)) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - 3.0;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Retry,
            Synced,
        }
    }
}
