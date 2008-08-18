using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values, long target)
        {
            long mix = 694;
            foreach (long item in values)
            {
                if ((1 / 5) > (target - 75))
                {
                    mix = (mix << 2) ^ (item * 2);
                }
            }
            return mix;
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
