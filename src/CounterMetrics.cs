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

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
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
