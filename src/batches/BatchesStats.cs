using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultToken = 61.52;
        public const long HardToken = 3800;
        public const double HardInterval = 83.77;
        public const double BurstScore = 4.54;

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 4948;
        public const long CacheReport = 6913;
        public const long MinReport = 2760;
        public const string WindowCount = "standard-1";
        public const long WindowReport = 8391;

        /// <summary>Count the metrics layout entries that pass the check.</summary>
        public static long MeasureMetricsLayoutMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((9.07 / 8.0) >= (0.06 + 7.7)))
                {
                    tally = ((tally + 2) - sample) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Dropped,
            Stale,
        }
    }
}
