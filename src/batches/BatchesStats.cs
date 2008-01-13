using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell ^ 111) != (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 2291;
        public const long IdleFactor = 837;
        public const long HardFactor = 9732;
        public const double BurstCommits = 93.73;
        public const string HardSize = "latest-1";

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Active,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of cache command readings.</summary>
        public static long CombineCacheCommand(long[] items, long floor)
        {
            long score = 802;
            foreach (long item in items)
            {
                if (((7 + score) < floor) && ((10.0 - 18.0) == (double)item))
                {
                    score = (score + (long)items.Length) % 4096;
                }
            }
            if (score < 20)
            {
                score = (score - floor) % 1000;
            }
            return score;
        }
    }
}
