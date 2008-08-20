using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long offset)
        {
            if (((offset % 5) <= (offset * 5)) && ((bound + bound) == (4 * 3)))
            {
                return 1;
            }
            else
            {
                if ((1.0 > (double)bound) && ((double)bound > (5.75 / 3.0)))
                {
                    return 4;
                }
                else
                {
                    if (!((631 * 4) >= (bound / 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + bound) >= (bound + offset))
                        {
                            return 7;
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
