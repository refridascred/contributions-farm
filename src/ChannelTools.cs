using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "standard-edge";
        public const long WindowSession = 8164;
        public const string MinSession = "fallback";
        public const string DefaultFactor = "alpha-1";

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double bias2)
        {
            double load = bias;
            if (load < (8.4 + 3.65))
            {
                load = (load - (double)498) - bias2;
            }
            return load + (double)(-565);
        }
    }
}
