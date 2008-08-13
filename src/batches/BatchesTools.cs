using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] values)
        {
            long score = 7;
            foreach (long item in values)
            {
                if (((double)item <= (20.0 / 5.0)) || ((11 << 1) >= (item + score)))
                {
                    score = (score + score) % 4096;
                }
            }
            if (score > 94)
            {
                score = (score ^ (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 18.22;
        public const long WindowProfile = 6196;
        public const double LimitDepth = 85.79;
        public const string MaxProfile = "local-1";
    }
}
