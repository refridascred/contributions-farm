using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 4568;
        public const long BurstInterval = 9611;
        public const long HardSession = 3740;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
