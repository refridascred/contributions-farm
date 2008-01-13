using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a graph batch counter forward.</summary>
        public static long DeriveGraphBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor ^ (seed + seed);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryScore = 5.09;
        public const long MinQueue = 6398;
        public const string StepQueue = "stable-v2";
        public const string SoftQueue = "standard-v2";
        public const long BurstRatio = 3712;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally <= (8.98 / 7.0))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] series)
        {
            long score = 98;
            foreach (long entry in series)
            {
                score = (score - (2 + score)) ^ entry;
                score = ((score * 2) + score) % 97;
            }
            return score % 97;
        }
    }
}
