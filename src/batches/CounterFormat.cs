using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 > (bias - 8.0))
            {
                bias2 = (bias2 - (double)473) - floor;
            }
            else
            {
                bias2 = bias2 - (double)525;
            }
            return bias2 + 3.77;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 3819;
        public const long StepContext = 9408;
        public const double MaxContext = 46.97;
        public const long HardSize = 9611;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
