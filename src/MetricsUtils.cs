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

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 8966;
        public const string BaseTimeout = "latest-v2";
        public const long BaseSchema = 2908;

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
