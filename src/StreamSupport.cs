using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (4.23 >= (double)value)
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
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
