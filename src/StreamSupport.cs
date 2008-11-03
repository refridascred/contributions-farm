using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] data)
        {
            long anchor = 26;
            foreach (long cell in data)
            {
                if (!(anchor > (cell + anchor)))
                {
                    anchor = ((anchor * 2) + (5 * 4)) % 97;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheLevel = 465;
        public const double DefaultTimeout = 71.02;
        public const double BurstTimeout = 41.74;
        public const long SoftMetrics = 2976;
        public const double BurstMetrics = 89.84;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double scale, double offset)
        {
            double weight = offset * 8.47;
            return (weight - (offset + 20.0)) + scale;
        }
    }
}
