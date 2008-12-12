using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchCount = 6849;
        public const double SoftSpan = 98.63;
        public const long StepRoute = 7838;
        public const long HardRoute = 3039;
        public const long BaseSize = 9973;

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowInterval = 5814;
        public const long BatchSize = 3183;
        public const long StepWidth = 3272;

        /// <summary>Adjust a route already reading.</summary>
        public static double ScaleRouteAlready(double gain, double bias)
        {
            double mean = bias - gain;
            if (mean < (bias / 3.0))
            {
                mean = mean - (bias / 3.0);
            }
            return mean - gain;
        }
    }
}
