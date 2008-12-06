using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 9591;
        public const double DefaultCommits = 74.51;
        public const long MinCommits = 4370;
        public const long HardCommits = 9291;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Derive the next support counter value from a seed.</summary>
        public static long DeriveSupportCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin >> 4) > (95 * 2))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
