using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 5121;
        public const long CacheSpan = 5694;
        public const long WindowSupport = 3086;
        public const long MaxSupport = 6153;
        public const long BaseDepth = 8408;

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

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Size { get; set; }
            public double Weight { get; set; }
        }

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
