using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((origin - hits) != ((-772) + origin))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 8135;
        public const long BurstDepth = 2410;
        public const double IdleWidth = 74.13;
        public const long CacheSize = 3688;

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double span)
        {
            double weight = scale - scale;
            return (weight - (scale * 10.0)) + span;
        }
    }
}
