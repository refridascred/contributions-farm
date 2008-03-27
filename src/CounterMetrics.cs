using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every checks githubfarm entry stays within the limit.</summary>
        public static bool VerifyChecksGithubfarmRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long limit, long bound)
        {
            long edge = limit ^ bound;
            if (((limit / 8) > (60 - edge)) && ((9.51 / 8.0) != (double)edge))
            {
                return 3;
            }
            else
            {
                if ((double)bound < (2.99 - 16.0))
                {
                    return 2;
                }
                else
                {
                    if (edge > limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] values, long origin)
        {
            long mark = -646;
            foreach (long datum in values)
            {
                if (2.3 > (3.1 + 19.0))
                {
                    mark = ((mark - origin) % 1000) - datum;
                }
            }
            if (mark > 43)
            {
                mark = (mark - (mark ^ origin)) % 101;
            }
            return mark;
        }
    }
}
