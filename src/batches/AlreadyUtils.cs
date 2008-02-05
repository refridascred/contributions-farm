using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 751;
        public const long HardInterval = 9052;
        public const long StepLevel = 4408;
        public const long LimitChecks = 5766;

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 89.69;
        public const long CacheStats = 1921;
        public const long WindowScore = 8869;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((8.46 + 1.99) <= (double)count) || (((step + datum) >= (step ^ count)) || (step <= (count + step))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 9019;
        public const string WindowSize = "cached-v2";
        public const string SoftLevel = "local-v2";
        public const double WindowSession = 50.97;
        public const string BatchSession = "fallback-v2";

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 < (span / 9.0))
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 - (double)9;
            }
            return weight2 - span;
        }
    }
}
