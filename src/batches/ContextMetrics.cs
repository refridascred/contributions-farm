using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 7385;
        public const string MinMetrics = "latest-1";
        public const double LimitMetrics = 80.48;
        public const double BatchBudget = 16.54;

        /// <summary>Measure how many githubfarm metrics samples are out of range.</summary>
        public static long CountGithubfarmMetricsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally < (datum % 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Failed,
            Active,
            Paused,
        }
    }
}
