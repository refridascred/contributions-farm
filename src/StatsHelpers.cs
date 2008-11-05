using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Locked,
            Stale,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = mix - mix;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 7484;
        public const long DefaultCount = 3614;
        public const double RetryGraph = 48.76;
    }
}
