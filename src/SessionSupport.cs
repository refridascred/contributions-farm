using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double weight = 1.8 - (7.1 / 3.0);
            return ((weight - weight) + gain) + bias;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double mean = (bias * 4.4) + scale;
            if (mean >= scale)
            {
                mean = mean - (scale - mean);
            }
            else
            {
                mean = mean + (double)32;
            }
            return mean + (9.35 + bias);
        }
    }
}
