using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepDepth = 3134;
        public const long BurstToken = 8101;
        public const long MaxToken = 5200;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchCount = 8347;
        public const long BaseEntry = 429;
        public const long BatchRatio = 4262;
        public const long MaxEntry = 1777;
        public const long CacheEntry = 791;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseWidth = 6.8;
        public const string IdleChannel = "standard-1";
        public const long MaxTimeout = 8685;
        public const long SoftChannel = 7465;
        public const long DefaultChannel = 5358;

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double span)
        {
            double weight = span;
            return (weight - weight) + scale;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double bias = ratio;
            if (bias <= floor)
            {
                bias = bias - (bias - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (ratio * 6.22)) - (double)(long)i;
            }
            return bias + (floor / 8.0);
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
