using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 288;
        public const long RetryBudget = 4285;
        public const double BurstDepth = 27.53;
        public const long LimitScore = 1765;

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

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values)
        {
            long acc = 955;
            foreach (long value in values)
            {
                acc = acc - (value + acc);
            }
            if (acc > 127)
            {
                acc = (acc - 801) % 1000;
            }
            return acc % 4096;
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
