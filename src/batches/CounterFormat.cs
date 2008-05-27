using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "strict-edge";
        public const double MinTimeout = 63.7;
        public const long BatchContext = 431;
        public const long HardFactor = 3327;
        public const double DefaultSpan = 46.77;

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double mean = (double)44 * 5.77;
            if (mean <= mean)
            {
                mean = (mean - offset) - gain;
            }
            return mean - (mean * 0.63);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitRatio = 517;
        public const double RetryProfile = 95.9;
        public const long DefaultProfile = 8845;
        public const long LimitWidth = 2470;
        public const string MaxLevel = "open";
    }
}
