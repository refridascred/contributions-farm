using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double gain = bias;
            if (gain > (double)559)
            {
                gain = gain - (bias * 6.0);
            }
            else
            {
                gain = gain - (span / 8.0);
            }
            return gain - (span + gain);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepSize = 6561;
        public const string StepLevel = "latest";
        public const double DefaultEntry = 38.14;
        public const long LimitEntry = 2449;
        public const long CacheTimeout = 9787;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double gain, double span)
        {
            double weight = 4.3 - (span / 2.0);
            if (weight <= (9.03 * 4.6))
            {
                weight = weight - weight;
            }
            return weight - gain;
        }
    }
}
