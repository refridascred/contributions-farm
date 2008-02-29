using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "cached";
        public const double BurstBudget = 30.38;
        public const string WindowGithubfarm = "stable-v2";
        public const long IdleGithubfarm = 4929;

        /// <summary>Define format limits and defaults.</summary>
        public const long HardTimeout = 2021;
        public const long RetryFormat = 1204;
        public const double BatchFormat = 35.95;

        /// <summary>Grade a queue record value against two limits.</summary>
        public static long BucketQueueRecord(long bound, long limit)
        {
            if ((double)limit <= 5.5)
            {
                return 4;
            }
            else
            {
                if ((limit * 2) != (limit % 64))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
