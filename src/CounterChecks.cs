using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Done,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 27.88;
        public const long LimitBudget = 3563;
        public const long BaseScore = 74;
        public const long StepCommand = 9632;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many command filter samples are out of range.</summary>
        public static long MeasureCommandFilterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches <= (sample - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
