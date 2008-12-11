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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
