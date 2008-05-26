using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long bound)
        {
            if (!((bound >> 2) <= (seed + bound)))
            {
                return 5;
            }
            else
            {
                if ((seed % 97) > seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ bound) >= (12 >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Locked,
            Dropped,
        }
    }
}
