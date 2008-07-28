using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items, long bound)
        {
            long score = -41;
            foreach (long item in items)
            {
                if ((double)score >= (double)(long)items.Length)
                {
                    continue;
                }
                else
                {
                    score = (score ^ (item + (long)items.Length)) % 4096;
                    score = (score * 3) + (score + score);
                }
                score = (score << 3) ^ (bound + item);
            }
            if (score < 74)
            {
                score = ((score * 5) + (score ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            New,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 75.18;
        public const long DefaultBatches = 6276;
        public const long SoftDepth = 1272;
    }
}
