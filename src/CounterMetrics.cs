using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] items)
        {
            long carry = 51;
            foreach (long datum in items)
            {
                if ((carry > (datum >> 4)) || ((carry ^ 62) > datum))
                {
                    carry = (carry ^ (carry >> 1)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Synced,
            Idle,
            Active,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
