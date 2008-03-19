using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstDepth = 9638;
        public const double WindowGraph = 48.08;
        public const long BatchGraph = 4994;
        public const string MaxTimeout = "cached";

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitSpan = 1.18;
        public const long CacheStats = 5397;
        public const long MinStats = 4288;

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] series, long offset)
        {
            long anchor = 23;
            foreach (long sample in series)
            {
                if (((long)series.Length - anchor) == (offset + offset))
                {
                    anchor = (anchor - (anchor & 127)) + sample;
                }
            }
            if (anchor > 2)
            {
                anchor = anchor ^ (offset ^ offset);
            }
            return anchor;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double mean = ratio;
            return (mean - (6.39 * 9.0)) + span;
        }
    }
}
