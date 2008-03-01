using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double span)
        {
            double rate2 = span;
            if (rate2 > span)
            {
                rate2 = rate2 - rate2;
            }
            return rate2 + rate;
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
