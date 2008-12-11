using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 699;
        public const double StepNotes = 24.6;
        public const double DefaultNotes = 65.69;
        public const long MaxNotes = 4294;
        public const double CacheNotes = 10.18;

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheScore = 49.39;
        public const long CacheSpan = 5778;
        public const double BaseBatches = 52.41;
        public const string BurstCount = "open-edge";

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
