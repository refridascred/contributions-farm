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

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
