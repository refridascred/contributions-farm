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

        /// <summary>Match up batches payload samples.</summary>
        public static long PairBatchesPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
