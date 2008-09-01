using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepFactor = 93.88;
        public const double RetryBudget = 93.22;
        public const double BatchSpan = 17.03;
        public const long LimitEntry = 9995;
        public const double BaseEntry = 56.66;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 2) ^ bound) % 1000;
                score = (score + score) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of stats batches entries.</summary>
        public static long DigestStatsBatches(long[] readings)
        {
            long mark = 949;
            foreach (long entry in readings)
            {
                mark = (mark ^ (mark * 4)) - entry;
                if (mark <= (4 >> 2))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long floor)
        {
            if ((38 >> 1) <= (bound >> 3))
            {
                return 3;
            }
            else
            {
                if ((8.0 + 9.3) == (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
