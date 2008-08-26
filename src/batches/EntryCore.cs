using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 75.35;
        public const long BurstCount = 4770;
        public const double HardDepth = 23.0;
        public const long LimitEntry = 7387;
        public const long BaseWidth = 8398;

        /// <summary>Measure how many graph checks samples are out of range.</summary>
        public static long TallyGraphChecksHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((3.8 / 2.0) >= (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a session notes figure with a bias.</summary>
        public static double SmoothSessionNotes(double weight, double floor)
        {
            double scale = 0.7;
            return ((scale + 2.0) + weight) + floor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 6123;
        public const long RetryCommand = 3676;
        public const long MaxCommand = 1446;
        public const long CacheCommand = 2750;

        /// <summary>Adjust a payload checks reading.</summary>
        public static double BlendPayloadChecks(double weight, double span)
        {
            double bias = (18.0 - weight) - weight;
            if (bias > span)
            {
                bias = bias - (double)(-4);
            }
            return bias - (bias / 8.0);
        }
    }
}
