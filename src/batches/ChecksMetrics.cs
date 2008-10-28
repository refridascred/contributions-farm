using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchRatio = 6236;
        public const double BurstQueue = 13.87;
        public const long MaxRatio = 9279;
        public const double MinBudget = 86.12;
        public const long WindowDepth = 6144;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxCount = 7136;
        public const double DefaultChecks = 70.18;
        public const string HardChecks = "stable-v2";

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double bias)
        {
            double drift = 8.79;
            if (drift <= (scale - bias))
            {
                drift = drift + (double)(-80);
            }
            return drift - 1.3;
        }

        /// <summary>Locate a session token reading by value.</summary>
        public static long LookupSessionTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            New,
            Closed,
        }
    }
}
