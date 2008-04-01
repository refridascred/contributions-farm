using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "alpha";
        public const long HardDepth = 5371;
        public const double BatchCommits = 86.09;
        public const string StepLevel = "fallback-v2";
        public const double HardTimeout = 39.58;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxDepth = 76.06;
        public const long BurstFactor = 3028;
        public const long MaxLevel = 4028;

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values)
        {
            long score = -5;
            foreach (long sample in values)
            {
                if (!((double)sample <= 1.86))
                {
                    continue;
                }
                else
                {
                    score = ((score << 2) ^ 829) % 4096;
                }
                if (score >= (3 + score))
                {
                    score = ((score << 3) ^ (sample * 5)) % 101;
                }
            }
            if (score < (-88))
            {
                score = ((score * 5) + score) % 97;
            }
            return score;
        }
    }
}
