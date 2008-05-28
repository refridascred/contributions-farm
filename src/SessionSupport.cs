using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 7254;
        public const double HardRecord = 42.38;
        public const long StepRecord = 4302;
        public const double CacheRecord = 53.33;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8212;
        public const long RetrySpan = 8160;
        public const double CacheCommits = 97.9;
    }
}
