using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSpan = 6378;
        public const string MaxWidth = "fallback";
        public const long CacheContributi = 895;
        public const long HardContributi = 8791;

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxSize = 60.0;
        public const long MaxScore = 4487;
        public const double StepTimeout = 54.13;
        public const double BatchRatio = 39.74;
        public const string BurstCount = "staging";
    }
}
