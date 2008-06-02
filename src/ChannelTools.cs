using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCount = 6612;
        public const double MinLevel = 95.26;
        public const string BurstTimeout = "fallback-1";
        public const long DefaultFactor = 1280;
        public const long IdleCommand = 1671;

        /// <summary>Measure how many schema format samples are out of range.</summary>
        public static long TallySchemaFormatOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((hits + (long)readings.Length) < (value * 5)) && (((hits ^ hits) <= hits) || ((value << 2) != (value % 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
