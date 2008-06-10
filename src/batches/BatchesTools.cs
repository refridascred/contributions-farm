using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "open-v2";
        public const long RetryTimeout = 5321;
        public const long BaseRoute = 9544;
        public const long WindowSize = 1064;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 300;
        public const long MinTools = 6916;
        public const string IdleTools = "fallback-1";
        public const string HardTools = "legacy";
        public const long BatchScore = 942;
    }
}
