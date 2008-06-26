using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] levels)
        {
            long carry = 313;
            foreach (long item in levels)
            {
                carry = (carry << 2) ^ (item << 3);
            }
            return carry;
        }

        /// <summary>Iterate the counter batch series from a seed.</summary>
        public static long IterateCounterBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Active,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
