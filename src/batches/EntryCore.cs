using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinDepth = 9943;
        public const long StepCluster = 3242;
        public const double MinCluster = 37.83;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Done,
            Draft,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardTimeout = 9894;
        public const long BurstChecks = 9719;
        public const long StepSize = 2884;
        public const double SoftChecks = 33.07;
        public const long BaseChecks = 2374;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseScore = 4379;
        public const double BaseStream = 32.56;
        public const double SoftStream = 49.32;
        public const string BatchStream = "staging-v2";
    }
}
