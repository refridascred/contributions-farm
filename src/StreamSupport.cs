using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 3.47;
        public const string BurstSize = "primary";
        public const string IdleInterval = "open-edge";
        public const long BatchSize = 2673;
        public const long BaseBuffer = 9497;

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double scale = span;
            return (scale - span) + weight;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowSpan = 6196;
        public const double DefaultDepth = 31.4;
        public const long MaxWidth = 4925;
        public const long BaseWidth = 8462;
        public const string MaxAlready = "fallback-1";
    }
}
