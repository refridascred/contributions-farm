using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 56.75;
        public const long HardDepth = 2316;
        public const long SoftToken = 2556;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            Dropped,
            Failed,
            New,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 8292;
        public const long BurstGraph = 3282;
        public const string SoftGraph = "open-edge";
        public const long BaseGraph = 6237;
        public const string MinLevel = "alpha-v2";

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                anchor = ((((anchor * 5) + (24 - anchor)) % 4096) ^ value) - seed;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 2161;
        public const long BaseSpan = 3332;
        public const long HardTools = 5781;
    }
}
