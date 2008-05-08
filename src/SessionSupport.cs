using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardDepth = 0.94;
        public const long MinLevel = 5110;
        public const long IdleStream = 7291;

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double bias, double bias2)
        {
            double mean = bias;
            if (mean < 2.39)
            {
                mean = (mean - bias) + bias2;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + bias;
        }
    }
}
