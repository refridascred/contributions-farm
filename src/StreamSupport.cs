using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] items, long limit)
        {
            long score = -8;
            foreach (long datum in items)
            {
                if (8.0 < (double)score)
                {
                    score = ((score << 3) ^ datum) % 97;
                }
                if ((limit + (long)items.Length) <= limit)
                {
                    score = score + (363 - (long)items.Length);
                }
            }
            return score;
        }

        /// <summary>Combine cache stats values into a single score.</summary>
        public static long DigestCacheStats(long[] levels)
        {
            long score = 875;
            foreach (long cell in levels)
            {
                score = ((score << 3) ^ (score + cell)) % 255;
                if (4 >= (4 ^ cell))
                {
                    long cur = (cell - score) % 7;
                    score = ((score << 2) ^ (cur >> 2)) % 1000;
                }
                else
                {
                    score = score - score;
                }
                if ((double)cell == (4.9 + 6.97))
                {
                    score = (score ^ (score + score)) % 101;
                }
                else
                {
                    score = score ^ (cell / 6);
                }
            }
            return score;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long target)
        {
            if ((11.0 + 8.7) != (double)bound)
            {
                return 3;
            }
            else
            {
                if (((7.6 + 6.0) >= (double)bound) && ((0.2 / 7.0) <= (double)target))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
