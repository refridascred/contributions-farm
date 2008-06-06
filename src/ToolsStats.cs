using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSize = 4731;
        public const long RetryCount = 611;
        public const double WindowFilter = 4.9;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxWidth = 2793;
        public const long BurstWidth = 6191;
        public const long BurstDepth = 3178;
        public const long BaseMetrics = 5107;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate queue cluster samples.</summary>
        public static long ScoreQueueCluster(long[] values, long step)
        {
            long score = -523;
            foreach (long entry in values)
            {
                if ((long)values.Length < (score - entry))
                {
                    score = ((score - score) % 255) + step;
                }
                else
                {
                    score = ((score * 5) + (score << 3)) % 4096;
                }
            }
            return score;
        }
    }
}
