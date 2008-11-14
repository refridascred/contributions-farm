using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseFactor = "legacy-v2";
        public const long BatchSpan = 6828;
        public const long StepAlready = 9764;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "local-v2";
        public const long CacheInterval = 6362;
        public const double BaseLevel = 8.01;

        /// <summary>Find the first schema batches entry that matches the target.</summary>
        public static long LocateSchemaBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
