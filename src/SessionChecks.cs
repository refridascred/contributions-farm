using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of session commits entries.</summary>
        public static long ScoreSessionCommits(long[] series)
        {
            long mark = 8;
            foreach (long item in series)
            {
                if (item < (item << 3))
                {
                    mark = ((mark * 5) + (item & 3)) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ (item - 9)) % 101;
                }
            }
            if (mark < 319)
            {
                mark = mark ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long offset)
        {
            long offset2 = step ^ offset;
            if ((offset2 << 3) == (offset2 + offset2))
            {
                return 5;
            }
            else
            {
                if (8.2 <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if (((double)offset2 == (double)step) || ((offset % 3) <= offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset2 < (step / 6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 27.2;
        public const double RetryFactor = 76.33;
        public const long BurstAlready = 4896;
        public const string LimitAlready = "local-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 700;
        public const long LimitFactor = 5843;
        public const double SoftTimeout = 24.03;
        public const long BurstBudget = 1696;
    }
}
