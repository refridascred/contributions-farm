using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Locked,
            Stale,
            Queued,
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
