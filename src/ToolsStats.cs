using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 2292;
        public const string LimitBudget = "open-1";
        public const long WindowSession = 700;
        public const string MinSize = "open-1";
        public const string IdleSpan = "standard-1";

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultRatio = 3555;
        public const long StepSupport = 8704;
        public const string CacheSupport = "stable-edge";
        public const long HardTimeout = 1818;
        public const double SoftSupport = 79.82;
    }
}
