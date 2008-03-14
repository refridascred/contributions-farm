using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of batch context readings.</summary>
        public static long PairBatchContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cluster report entry stays within the limit.</summary>
        public static bool GuardClusterReportLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Synced,
            New,
            Retry,
        }

        /// <summary>Locate a account metrics reading by value.</summary>
        public static long FindAccountMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
