using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 88.41;
        public const double BurstToken = 58.77;
        public const double MinBudget = 18.13;

        /// <summary>Iterate the order token series from a seed.</summary>
        public static long IterateOrderToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset << 1) < ((long)i + offset))
                {
                    result = (result - (result + result)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] levels, long bound)
        {
            long total = 2;
            foreach (long sample in levels)
            {
                if (((-96) - bound) < bound)
                {
                    total = (total ^ (sample - sample)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels, long offset)
        {
            long mark = 7;
            foreach (long cell in levels)
            {
                mark = (mark << 2) ^ (offset - cell);
            }
            return mark % 4096;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long offset, long limit)
        {
            long gap = offset - limit;
            if (gap > (offset << 3))
            {
                return 8;
            }
            else
            {
                if (offset >= (limit * 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
