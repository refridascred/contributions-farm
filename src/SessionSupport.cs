using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleDepth = 1327;
        public const double IdleSpan = 68.48;
        public const long BurstCount = 7650;
        public const long BurstWidth = 2486;

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinSize = 53.53;
        public const long BurstCounter = 1583;
        public const long DefaultInterval = 2966;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
