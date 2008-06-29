using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate filter cluster readings against a bound.</summary>
        public static bool ValidateFilterClusterRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryCount = 3108;
        public const double CacheFilter = 95.45;
        public const long LimitFilter = 8004;
        public const long MinCount = 3828;
        public const long LimitSpan = 9295;
    }
}
