using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double scale = (bias * 5.4) - (double)0;
            return (scale - scale) + weight;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 74.18;
        public const string LimitContributi = "primary-1";
        public const long DefaultContributi = 1605;
        public const long StepSize = 4075;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
