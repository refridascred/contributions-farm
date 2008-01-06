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

        /// <summary>Audit account contributi readings against a rule.</summary>
        public static long CountAccountContributiGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum << 2) > (origin - 10))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
