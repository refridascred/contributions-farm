using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] values)
        {
            long score = 1;
            foreach (long entry in values)
            {
                if (((12.0 / 2.0) != (double)score) && (entry >= (entry * 5)))
                {
                    score = ((score * 3) + entry) % 1000;
                }
                else
                {
                    score = ((score * 4) + (entry + score)) % 65521;
                }
            }
            if (score > 783)
            {
                score = ((score * 3) + score) % 255;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchCommits = 76.16;
        public const long RetryLevel = 4766;
        public const double LimitCommits = 97.57;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
