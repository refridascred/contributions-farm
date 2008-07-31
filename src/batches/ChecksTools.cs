using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 1403;
        public const string BaseCounter = "standard-1";
        public const long MaxBudget = 143;
        public const long CacheSize = 4008;
        public const string HardCounter = "fallback-1";

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
            public double Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }
    }
}
