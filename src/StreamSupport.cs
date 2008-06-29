using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
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
