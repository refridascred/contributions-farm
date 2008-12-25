using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 9237;
        public const string CacheSize = "cached-edge";
        public const long LimitBatch = 4151;
        public const long SoftRatio = 1497;
        public const long MinScore = 8770;

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 1296;
        public const string MaxCommand = "latest-1";
        public const long IdleCommand = 7857;
        public const long DefaultCommand = 9744;
        public const long BatchCommand = 3829;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((0.05 / 7.0) <= (double)item) || !((item << 3) < (item + limit)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
