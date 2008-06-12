using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9283;
        public const double BaseTimeout = 72.37;
        public const string LimitScore = "fallback-edge";

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 8293;
        public const double HardSize = 38.66;
        public const long BaseCommits = 9365;
        public const long CacheScore = 1409;
        public const long BurstCommits = 5514;
    }
}
