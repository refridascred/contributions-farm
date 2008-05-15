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

        /// <summary>Match up layout githubfarm samples.</summary>
        public static long CompareLayoutGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
