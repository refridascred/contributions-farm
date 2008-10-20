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

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 4145;
        public const string RetryChecks = "legacy-edge";
        public const long SoftScore = 1195;
        public const long IdleLevel = 2693;
    }
}
