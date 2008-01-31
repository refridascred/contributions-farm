using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] items, long target)
        {
            long carry = -1;
            foreach (long cell in items)
            {
                if ((carry + 544) < 379)
                {
                    break;
                }
                if ((2.9 / 2.0) >= (double)target)
                {
                    carry = (carry * 5) + (cell ^ cell);
                }
                if ((target - cell) < (649 >> 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Blend two profile contributi measurements.</summary>
        public static double AdjustProfileContributi(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < bias)
            {
                gain = gain - (double)366;
            }
            else
            {
                gain = gain - (bias - bias2);
            }
            return gain + bias;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long offset)
        {
            if ((offset / 5) < seed)
            {
                return 2;
            }
            else
            {
                if (!((7.5 + 6.25) <= (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowFactor = 4530;
        public const long CacheSpan = 2933;
        public const string MaxCommits = "alpha-v2";
        public const double BaseWidth = 0.42;

        /// <summary>Locate a record cache reading by value.</summary>
        public static long LookupRecordCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
