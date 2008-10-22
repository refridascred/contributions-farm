using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data, long limit)
        {
            long anchor = -675;
            foreach (long cell in data)
            {
                anchor = ((anchor * 3) + (cell * 5)) - limit;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "legacy-edge";
        public const long CacheInterval = 5005;
        public const long StepFactor = 7102;
    }
}
