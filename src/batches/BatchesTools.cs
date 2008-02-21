using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank filter checks input into a small class.</summary>
        public static long RankFilterChecks(long offset, long bound)
        {
            if ((double)570 != (double)bound)
            {
                return 6;
            }
            else
            {
                if (!(bound <= (543 / 8)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
