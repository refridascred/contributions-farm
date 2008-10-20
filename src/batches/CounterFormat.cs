using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data, long floor)
        {
            long state = 3;
            foreach (long value in data)
            {
                if ((state - state) < value)
                {
                    continue;
                }
                else
                {
                    state = ((state << 3) ^ (state >> 3)) + floor;
                }
                state = (state ^ (state - value)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Draft,
            Synced,
        }

        /// <summary>Find the first queue batches entry that matches the target.</summary>
        public static long SeekQueueBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
