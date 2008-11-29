using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheSpan = "open";
        public const long WindowLevel = 7950;
        public const long BurstDepth = 6762;
        public const long BatchMetrics = 3611;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryCount = "cached-v2";
        public const double IdleRatio = 96.78;
        public const long LimitWidth = 624;
        public const long BatchDepth = 2425;
        public const double WindowFactor = 75.94;

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardTimeout = "legacy-1";
        public const long WindowWidth = 1329;
        public const string CacheDepth = "stable";
        public const string BaseRatio = "open-edge";
    }
}
