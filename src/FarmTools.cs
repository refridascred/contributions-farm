using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Synced,
            New,
            Done,
            Closed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "stable";
        public const long RetryStream = 6859;
        public const long RetryLevel = 8872;
        public const long IdleDepth = 5794;
        public const string MinDepth = "open-1";

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series)
        {
            long score = 4;
            foreach (long datum in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score << 3) ^ (score & 7)) % 255) ^ (long)i;
                }
                if ((7.91 + 8.1) < (double)datum)
                {
                    score = (score * 4) + score;
                }
            }
            if (score > 9)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 65521;
        }
    }
}
