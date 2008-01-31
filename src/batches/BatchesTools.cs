using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the stats tools series from a seed.</summary>
        public static long RollStatsTools(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = carry - ((long)i + carry);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] data, long offset)
        {
            long acc = -4;
            foreach (long value in data)
            {
                acc = ((acc + (offset + acc)) % 255) ^ value;
            }
            return acc;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            New,
            Idle,
            Closed,
            Queued,
        }
    }
}
