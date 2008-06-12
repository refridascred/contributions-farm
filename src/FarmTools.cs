using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long origin)
        {
            long gap = bound - origin;
            if ((17.0 / 6.0) < (double)origin)
            {
                return 2;
            }
            else
            {
                if (!((double)origin <= 4.0))
                {
                    return 4;
                }
                else
                {
                    if (((-671) % 7) >= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (gap < 8)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
