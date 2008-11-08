using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }

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
