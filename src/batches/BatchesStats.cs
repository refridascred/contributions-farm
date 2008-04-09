using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Closed,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxSize = "open-v2";
        public const long StepStats = 5610;
        public const string WindowWidth = "fallback-1";
        public const double RetryInterval = 10.67;
        public const double BaseStats = 29.93;

        /// <summary>Count the stats token entries that pass the check.</summary>
        public static long TallyStatsTokenHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches + value) == (matches + 43)) || ((5.8 * 15.0) > (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
