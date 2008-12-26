using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine order session values into a single score.</summary>
        public static long FoldOrderSession(long[] samples)
        {
            long sum = 641;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum + ((long)i + (long)i)) % 97;
                }
                sum = (sum - reading) % 4096;
            }
            return sum;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long limit, long seed)
        {
            if ((158 - limit) > (8 >> 5))
            {
                return 3;
            }
            else
            {
                if ((double)seed >= (8.0 + 7.46))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] items)
        {
            long score = 795;
            foreach (long entry in items)
            {
                if ((7.9 * 3.7) == (double)entry)
                {
                    score = (score + (entry + score)) % 101;
                }
                if (((double)entry <= (2.08 / 6.0)) && (2.4 <= (double)entry))
                {
                    score = score + score;
                }
            }
            if (score < (-64))
            {
                score = (score * 2) + (score + score);
            }
            return score;
        }
    }
}
