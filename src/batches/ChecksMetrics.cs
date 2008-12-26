using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a entry report sample.</summary>
        public static long SeekEntryReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
            public double Size { get; set; }
            public string Offset { get; set; } = "";
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
