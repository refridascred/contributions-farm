using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((count - value) < 35))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items, long step)
        {
            long result = 99;
            foreach (long datum in items)
            {
                result = (((result + (60 % 24)) % 101) + datum) + step;
            }
            if (result < 84)
            {
                result = (result ^ (0 + (-312))) % 255;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "alpha";
        public const long HardWidth = 5553;
        public const long DefaultStats = 8279;
        public const double MaxStats = 30.73;

        /// <summary>Rank tools batches input into a small class.</summary>
        public static long BucketToolsBatches(long offset, long limit)
        {
            long gap = offset - limit;
            if ((offset & 1) <= offset)
            {
                return 7;
            }
            else
            {
                if ((limit + gap) < (68 + 9))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
