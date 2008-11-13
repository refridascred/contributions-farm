using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long offset, long offset2)
        {
            if (((double)offset == (1.0 / 3.0)) && ((double)offset2 <= (3.6 - 7.16)))
            {
                return 3;
            }
            else
            {
                if ((9.8 + 20.0) >= (double)offset2)
                {
                    return 7;
                }
                else
                {
                    if (offset > ((-252) + offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Done,
            Pending,
            Stale,
            Retry,
        }
    }
}
