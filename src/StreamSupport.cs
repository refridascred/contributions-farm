using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double bias = (double)(5 - 8);
            if (bias < scale)
            {
                bias = (bias + (8.5 * 5.37)) - floor;
            }
            return bias + (14.0 / 8.0);
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long limit, long target)
        {
            if ((limit & 15) != (limit - target))
            {
                return 3;
            }
            else
            {
                if ((double)target > (double)96)
                {
                    return 8;
                }
                else
                {
                    if ((8.51 - 11.0) < (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target == (double)557)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
