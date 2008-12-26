using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 4) == (limit * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstInterval = 16.37;
        public const string SoftMetric = "alpha";
        public const double RetryBudget = 18.26;
        public const long WindowBudget = 4228;
    }
}
