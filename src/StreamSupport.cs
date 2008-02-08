using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleTimeout = 8397;
        public const double StepOrder = 93.55;
        public const long MaxLevel = 23;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
