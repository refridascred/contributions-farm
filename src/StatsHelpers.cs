using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream cluster entries.</summary>
        public static long CombineStreamCluster(long[] data, long floor)
        {
            long state = 405;
            foreach (long entry in data)
            {
                if (((7.0 / 9.0) < (double)floor) || ((double)state >= (5.9 / 6.0)))
                {
                    state = state + (3 + entry);
                }
                else
                {
                    state = (state + (61 >> 1)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
