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

        /// <summary>Count the cache order entries that pass the check.</summary>
        public static long TallyCacheOrderHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((value - step) < (52 * 4)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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
