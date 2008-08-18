using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two already graph measurements.</summary>
        public static double BlendAlreadyGraph(double rate, double span)
        {
            double ratio = (double)229 + (span * 1.9);
            if (ratio >= 6.07)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - span) - (double)(long)i;
            }
            return ratio + rate;
        }

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
