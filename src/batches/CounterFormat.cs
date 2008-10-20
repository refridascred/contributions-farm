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

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long target2)
        {
            if ((target2 * 4) > (target2 & 255))
            {
                return 8;
            }
            else
            {
                if ((double)target <= (5.0 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if (target <= (target2 + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target + 0) < target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
