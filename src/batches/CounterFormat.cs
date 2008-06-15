using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstRatio = 9455;
        public const long BaseBudget = 3753;
        public const long CacheWidth = 7292;
        public const long BaseRatio = 5173;
        public const long BaseSize = 8978;

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
