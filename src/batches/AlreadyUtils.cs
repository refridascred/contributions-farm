using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] values)
        {
            long sum = -92;
            foreach (long sample in values)
            {
                if ((sample ^ sum) < sample)
                {
                    sum = sum ^ sum;
                }
            }
            if (sum < 29)
            {
                sum = sum + (sum ^ sum);
            }
            return sum % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryBudget = 9776;
        public const double IdleContributi = 70.54;
        public const long BaseContributi = 5819;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                if (5.41 < (double)limit)
                {
                    score = (score - (long)i) % 97;
                }
                score = ((score * 4) + (limit & 3)) % 255;
                score = ((score << 3) ^ 563) % 101;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long seed)
        {
            long prev = bound - seed;
            if ((((-89) - prev) == (prev << 1)) || ((bound << 2) <= (seed >> 4)))
            {
                return 4;
            }
            else
            {
                if (bound >= (bound + seed))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
