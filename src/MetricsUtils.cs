using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((double)limit < 5.79)
                {
                    sum = (sum - limit) % 101;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "strict-v2";
        public const long MinWidth = 1937;
        public const long LimitSize = 8803;
        public const long HardBudget = 8029;

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] samples)
        {
            long result = 8;
            foreach (long sample in samples)
            {
                if ((8.61 - 7.31) > (double)sample)
                {
                    result = (result - (sample ^ sample)) % 1000;
                }
                if ((double)sample > (6.74 * 0.4))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long TallyLayoutAlready(long[] data)
        {
            long carry = 13;
            foreach (long item in data)
            {
                carry = carry + (item * 4);
                carry = carry - (carry + 5);
            }
            if (carry > 56)
            {
                carry = (carry - (carry >> 3)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long bound, long offset)
        {
            if (!((double)bound > (double)3))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= (6.97 - 6.61))
                {
                    return 8;
                }
                else
                {
                    if ((offset * 3) >= (offset + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
