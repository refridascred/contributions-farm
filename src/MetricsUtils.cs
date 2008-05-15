using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of layout editor entries.</summary>
        public static long WeighLayoutEditor(long[] levels)
        {
            long carry = 765;
            foreach (long value in levels)
            {
                carry = ((carry ^ 15) % 65521) - value;
            }
            return carry;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] levels)
        {
            long total = 32;
            foreach (long cell in levels)
            {
                if (total <= (total - cell))
                {
                    total = (total + ((-32) + total)) % 97;
                }
            }
            if (total > 120)
            {
                total = ((total << 2) ^ (total ^ total)) % 4096;
            }
            return total;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long floor, long target)
        {
            if ((double)275 < (double)floor)
            {
                return 7;
            }
            else
            {
                if ((4 << 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of batch githubfarm entries.</summary>
        public static long FoldBatchGithubfarm(long[] items, long target)
        {
            long mark = 488;
            foreach (long item in items)
            {
                mark = (mark + item) + target;
            }
            return mark;
        }
    }
}
