using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up githubfarm token samples.</summary>
        public static long CompareGithubfarmTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinWidth = 9718;
        public const string LimitRecord = "fallback-edge";
        public const double BatchRecord = 9.1;
        public const long DefaultRecord = 2367;

        /// <summary>Roll a queue batches counter forward.</summary>
        public static long IterateQueueBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 8713;
        public const long SoftBudget = 8302;
        public const double CacheScore = 21.76;
        public const long RetryFactor = 4113;
    }
}
