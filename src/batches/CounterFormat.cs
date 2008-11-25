using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Count { get; set; }
            public double Weight { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 4142;
        public const long MinRecord = 9727;
        public const string MaxRecord = "legacy-v2";
    }
}
