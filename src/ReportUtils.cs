using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 1891;
        public const string RetryBudget = "stable-edge";
        public const long DefaultProfile = 7141;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length & 1) >= (hits + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
