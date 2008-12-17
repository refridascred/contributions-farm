using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MinCounter = "legacy-1";
        public const double MinSize = 24.14;
        public const long CacheLevel = 2714;
        public const long LimitCounter = 5041;
        public const long BurstSize = 7332;

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] series, long offset)
        {
            long score = 577;
            foreach (long cell in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score ^ (cell + 69)) % 101) + (long)i;
                }
                if (((9.12 + 4.0) != (double)cell) && ((offset / 9) < (score + offset)))
                {
                    score = (score * 4) + (score ^ offset);
                }
                else
                {
                    score = score ^ score;
                    score = score ^ (offset * 5);
                }
                score = score + (score / 4);
            }
            return score % 4096;
        }

        /// <summary>Classify a context farm pair into a bucket.</summary>
        public static long ClassifyContextFarm(long bound, long bound2)
        {
            if ((bound - 53) > (bound * 3))
            {
                return 3;
            }
            else
            {
                if ((double)bound > 9.7)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
