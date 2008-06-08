using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "fallback-1";
        public const double RetryLevel = 61.64;
        public const string CacheLayout = "legacy-edge";
        public const long IdleRatio = 1295;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
