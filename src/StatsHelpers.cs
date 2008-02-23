using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Draft,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((7.0 * 15.0) <= (double)datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6802;
        public const long BatchAccount = 9515;
        public const double DefaultTimeout = 63.59;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Label { get; set; }
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
