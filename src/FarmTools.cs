using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 8696;
        public const double RetryTimeout = 68.02;
        public const double BatchSize = 50.04;
        public const long RetryChecks = 2086;

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 90.87;
        public const string BatchWidth = "alpha-1";
        public const long BaseCommand = 8892;
        public const long HardSpan = 3244;
        public const double DefaultCommand = 73.4;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 >= 7.0)
            {
                rate2 = rate2 + (span / 8.0);
            }
            return rate2 - 6.9;
        }
    }
}
