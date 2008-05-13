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

        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "alpha-1";
        public const double LimitAlready = 38.26;
        public const long SoftAlready = 8071;
        public const long WindowScore = 8808;
        public const long RetryAlready = 5867;
    }
}
