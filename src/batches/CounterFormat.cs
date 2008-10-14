using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double mean = 19.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + mean) + (double)(long)i) - offset;
            }
            return mean - (9.2 - scale);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepRatio = 2155;
        public const long StepContext = 9296;
        public const long SoftContext = 3826;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Failed,
            Ready,
        }
    }
}
