using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
        }

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

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
        }
    }
}
