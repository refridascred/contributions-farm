using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long offset)
        {
            long total = 40;
            foreach (long value in samples)
            {
                total = ((total << 2) ^ (total + offset)) + value;
            }
            return total % 1000;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long bound, long target)
        {
            if ((8.18 * 0.04) >= (double)bound)
            {
                return 1;
            }
            else
            {
                if (target < 40)
                {
                    return 6;
                }
                else
                {
                    if ((target + bound) >= 3)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(target >= (target ^ 17)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                if (score > (origin << 3))
                {
                    score = score ^ (457 / 6);
                    score = ((score << 2) ^ ((long)i - score)) % 65521;
                }
                else
                {
                    score = ((score * 3) + (score % 16)) % 255;
                    score = score + 0;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
