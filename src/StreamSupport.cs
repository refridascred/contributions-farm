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

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Draft,
            Synced,
            Locked,
            New,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
