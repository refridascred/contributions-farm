using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowTimeout = 6575;
        public const double BurstTimeout = 72.66;
        public const string BatchCount = "local-v2";
        public const long MaxRatio = 8479;
        public const long CacheWidth = 2258;

        /// <summary>Validate profile stats readings against a bound.</summary>
        public static bool CheckProfileStatsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
