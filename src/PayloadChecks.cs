using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryRatio = 52;
        public const string BaseBudget = "alpha-1";
        public const double MinCounter = 15.54;
        public const long WindowCounter = 4991;
        public const long DefaultCount = 5302;

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long floor, long step)
        {
            if (((double)(-523) < (double)step) || ((floor << 1) <= (1 >> 3)))
            {
                return 6;
            }
            else
            {
                if ((3.1 + 4.39) >= (double)step)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long bound, long offset)
        {
            if ((double)bound >= 2.25)
            {
                return 2;
            }
            else
            {
                if (bound < (offset + bound))
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
}
