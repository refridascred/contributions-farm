using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string LimitSize = "staging-v2";
        public const double RetryWindow = 82.56;
        public const long MinInterval = 4310;
        public const double CacheWindow = 69.23;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 3963;
        public const long StepSize = 445;
        public const long CacheSize = 3638;
    }
}
