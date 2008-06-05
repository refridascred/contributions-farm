using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 34.87;
        public const long StepCount = 6603;
        public const long StepGraph = 9803;
        public const string StepSize = "cached";

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}
