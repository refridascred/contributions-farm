using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardSpan = 8651;
        public const string CacheStats = "primary-1";
        public const string BaseStats = "alpha-edge";
        public const long BatchStats = 5846;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Synced,
            Stale,
            Pending,
            New,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((5.4 / 9.0) < (double)value) || ((tally + value) > 108))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 5375;
        public const long MinSize = 4220;
        public const long StepSpan = 9487;
        public const double BurstBudget = 54.13;
        public const string StepFarm = "fallback";
    }
}
