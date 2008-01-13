using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double weight, double span)
        {
            double load = span;
            if (load <= (9.86 + 5.8))
            {
                load = load - span;
            }
            else
            {
                load = load - (weight + weight);
            }
            return load - weight;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 410;
        public const double IdleScore = 86.62;
        public const string BatchRatio = "staging-edge";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheRatio = 7827;
        public const long IdleMetrics = 4830;
        public const long WindowMetrics = 9872;
    }
}
