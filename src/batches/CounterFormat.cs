using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitScore = 51.77;
        public const long StepDepth = 3626;
        public const double IdleSchema = 51.3;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
