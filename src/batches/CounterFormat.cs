using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 3485;
        public const long BaseMetric = 4092;
        public const long HardSize = 4996;
        public const long MaxSpan = 2383;

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowInterval = "strict-edge";
        public const string DefaultSize = "strict-1";
        public const double BurstFactor = 15.33;

        /// <summary>Scale a filter context figure with a bias.</summary>
        public static double ScaleFilterContext(double gain, double floor)
        {
            double load = (double)4;
            if (load >= load)
            {
                load = load - (gain + 4.28);
            }
            else
            {
                load = load - (floor / 3.0);
            }
            return load + gain;
        }
    }
}
