using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchLevel = 4699;
        public const long IdleDepth = 4063;
        public const long MinProfile = 2230;
        public const long RetryBudget = 1788;
        public const long CacheProfile = 1191;

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                score = (((score * 3) + (long)levels.Length) % 65521) - cell;
            }
            if (score < (-564))
            {
                score = (score << 3) ^ (score << 3);
            }
            return score;
        }
    }
}
