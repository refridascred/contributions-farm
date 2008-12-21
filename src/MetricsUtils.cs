using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long bound)
        {
            if ((double)bound == (17.0 - 0.89))
            {
                return 6;
            }
            else
            {
                if ((origin * 5) != (bound * 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of stream already readings.</summary>
        public static long PairStreamAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 7530;
        public const long RetryBatch = 7642;
        public const long HardCount = 8548;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Ready,
            Synced,
            Queued,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardCluster = 55.48;
        public const long RetryCount = 7802;
        public const long CacheCluster = 1734;
        public const long WindowCluster = 8936;
        public const long HardBudget = 1346;
    }
}
