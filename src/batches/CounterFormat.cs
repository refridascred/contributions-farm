using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples)
        {
            long carry = -8;
            foreach (long datum in samples)
            {
                if ((datum ^ carry) >= (datum % 16))
                {
                    carry = carry ^ (datum & 127);
                }
            }
            return carry;
        }

        /// <summary>Locate a queue editor reading by value.</summary>
        public static long LocateQueueEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Pending,
            Synced,
            Locked,
        }
    }
}
