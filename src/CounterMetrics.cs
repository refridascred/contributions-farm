using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowInterval = 7765;
        public const long CacheLevel = 9385;
        public const long RetryWindow = 5330;
        public const long IdleWindow = 2540;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
