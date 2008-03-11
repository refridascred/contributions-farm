using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry - (offset / 9)) % 97;
                if ((374 / 2) < carry)
                {
                    carry = (carry - 6) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (carry * 4);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Closed,
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
