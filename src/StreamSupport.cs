using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double MinFactor = 76.56;
        public const double BatchSchema = 44.82;
        public const string CacheLevel = "fallback-1";
        public const long DefaultSchema = 2716;
        public const string LimitSchema = "legacy-v2";

        /// <summary>Validate cache queue readings against a bound.</summary>
        public static bool CheckCacheQueueLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
