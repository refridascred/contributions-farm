using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long offset)
        {
            long total = 40;
            foreach (long value in samples)
            {
                total = ((total << 2) ^ (total + offset)) + value;
            }
            return total % 1000;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long bound, long target)
        {
            if ((8.18 * 0.04) >= (double)bound)
            {
                return 1;
            }
            else
            {
                if (target < 40)
                {
                    return 6;
                }
                else
                {
                    if ((target + bound) >= 3)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(target >= (target ^ 17)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((9.98 / 6.0) < (double)hits)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
