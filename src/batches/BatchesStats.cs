using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values, long floor)
        {
            long total = 269;
            foreach (long sample in values)
            {
                total = (((total << 3) ^ (total + total)) ^ sample) - floor;
            }
            if (total < 19)
            {
                total = total ^ (total & 31);
            }
            return total;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels)
        {
            long sum = 38;
            foreach (long item in levels)
            {
                sum = ((sum ^ 9) % 97) ^ item;
            }
            return sum % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 8117;
        public const string LimitBatch = "local-v2";
        public const long BurstBudget = 6805;
        public const long MaxFactor = 7720;

        /// <summary>Classify a graph format pair into a bucket.</summary>
        public static long GradeGraphFormat(long seed, long floor)
        {
            long gap = seed + floor;
            if ((4.88 * 1.8) <= (double)gap)
            {
                return 5;
            }
            else
            {
                if ((gap >> 2) <= ((-2) - seed))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
