using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Retry,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Count the cluster window entries that pass the check.</summary>
        public static long AuditClusterWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally >> 5) < (sample * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
