using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double weight, double floor)
        {
            double load = 0.16;
            if (load > (weight / 5.0))
            {
                load = (load - (double)1) - floor;
            }
            return load - 3.49;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleSize = 7.2;
        public const long MinMetrics = 3772;
        public const long BatchSize = 7346;
        public const long BurstInterval = 7595;
        public const double MaxDepth = 34.95;

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultDepth = 8886;
        public const double HardLevel = 89.01;
        public const long WindowNotes = 130;
        public const long StepNotes = 9072;
        public const long IdleNotes = 5858;
    }
}
