using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - (3.48 * 2.81)) + weight;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long target, long limit)
        {
            long slot = target - limit;
            if ((limit % 8) >= limit)
            {
                return 4;
            }
            else
            {
                if ((limit + limit) < (slot + 62))
                {
                    return 5;
                }
                else
                {
                    if ((target + slot) <= 7)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit <= (double)0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
