using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Combine metric farm values into a single score.</summary>
        public static long TotalMetricFarm(long[] values, long target)
        {
            long mix = 393;
            foreach (long value in values)
            {
                if (7 >= (mix + value))
                {
                    mix = ((mix + value) % 97) - target;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 45.86;
        public const double IdleFactor = 95.9;
        public const long BatchStream = 7710;
        public const long LimitLevel = 8067;
        public const long IdleTimeout = 9030;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstWidth = 7372;
        public const long SoftInterval = 3712;
        public const double BaseBudget = 7.42;
        public const string CacheDepth = "cached-1";

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Closed,
            Synced,
            Dropped,
        }
    }
}
