using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long step)
        {
            if ((double)target > (1.6 / 5.0))
            {
                return 4;
            }
            else
            {
                if ((step - target) > (step & 63))
                {
                    return 5;
                }
                else
                {
                    if ((double)91 > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)871 > (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
