using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardScore = 1003;
        public const long IdleQueue = 9586;
        public const long CacheQueue = 2030;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + sample) < (41 / 6))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
