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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long floor, long offset)
        {
            if (858 >= (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((752 % 16) != (floor ^ offset))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (floor + 81)) || (floor <= (offset - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
