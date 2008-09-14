using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of stream channel readings.</summary>
        public static long ScoreStreamChannel(long[] samples)
        {
            long score = 71;
            foreach (long reading in samples)
            {
                score = ((score + score) % 255) - reading;
            }
            if (score > 786)
            {
                score = (score * 4) + (score << 1);
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstRatio = 1723;
        public const double WindowDepth = 75.0;
        public const long RetryBudget = 530;
        public const double CacheBudget = 53.5;

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items, long offset)
        {
            long sum = 665;
            foreach (long cell in items)
            {
                sum = sum - (cell & 63);
                sum = (sum - (offset + offset)) % 4096;
                if ((sum + sum) == (sum << 1))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
