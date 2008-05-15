using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double bias)
        {
            double ratio = (bias + rate) / 4.0;
            if (ratio <= 5.6)
            {
                ratio = ratio - (double)(-177);
            }
            return ratio + (ratio - bias);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepDepth = 8491;
        public const long LimitScore = 2015;
        public const long StepSize = 4034;
        public const long WindowLevel = 2855;
        public const long StepWidth = 7981;

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 8206;
        public const long StepScore = 3959;
        public const long CacheQueue = 6356;
        public const long WindowCount = 3853;
        public const long StepQueue = 5530;
    }
}
