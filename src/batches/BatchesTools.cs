using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseSize = 938;
        public const double HardBuffer = 58.53;
        public const long BatchSize = 395;
        public const long MaxBuffer = 9024;
        public const long SoftBuffer = 6853;

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultCount = 6104;
        public const long SoftSize = 2521;
        public const long HardMetric = 2342;
        public const string SoftSpan = "fallback-v2";

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double weight, double offset)
        {
            double bias = (offset - 8.5) / 5.0;
            if (bias >= (weight - 11.0))
            {
                bias = bias + (double)32;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (offset - weight)) + (double)(long)i;
            }
            return bias - (bias * 2.8);
        }
    }
}
