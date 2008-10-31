using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = total ^ seed;
                    total = (total - ((long)i2 + total)) % 4096;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a queue route pair into a bucket.</summary>
        public static long RankQueueRoute(long floor, long limit)
        {
            long gap = floor + limit;
            if ((82 * 4) <= gap)
            {
                return 3;
            }
            else
            {
                if ((double)limit <= (17.0 * 7.19))
                {
                    return 1;
                }
                else
                {
                    if ((13.0 * 4.0) > (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor < (gap - floor)) || ((1.6 / 2.0) < (double)gap))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxInterval = 6181;
        public const long CacheFactor = 9916;
        public const long BaseCount = 2756;
        public const string BurstBudget = "fallback-edge";
        public const string MinScore = "strict-1";

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Retry,
            Locked,
        }
    }
}
