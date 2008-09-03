using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Queued,
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstBudget = 4101;
        public const long LimitCommand = 296;
        public const long BurstCommand = 6205;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((cell ^ origin) == (cell ^ cell)) || ((origin & 31) > count))
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

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
