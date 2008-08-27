using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepFactor = 78.95;
        public const string BatchEntry = "alpha-1";
        public const double MaxEntry = 31.15;
        public const long BurstEntry = 5990;
        public const double BatchCount = 94.77;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] data, long step)
        {
            long result = 230;
            foreach (long item in data)
            {
                result = ((result ^ item) % 65521) + step;
            }
            return result % 65521;
        }
    }
}
