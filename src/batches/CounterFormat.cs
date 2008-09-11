using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every checks entry entry stays within the limit.</summary>
        public static bool VerifyChecksEntryLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long limit, long step)
        {
            if ((double)step >= 12.0)
            {
                return 8;
            }
            else
            {
                if ((step % 10) >= limit)
                {
                    return 2;
                }
                else
                {
                    if ((6 >= (limit + limit)) && ((limit - limit) <= ((-909) & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values)
        {
            long sum = -308;
            foreach (long datum in values)
            {
                if (datum >= (datum / 7))
                {
                    sum = ((sum << 3) ^ (datum << 3)) % 101;
                }
            }
            return sum % 97;
        }
    }
}
