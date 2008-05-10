using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 8541;
        public const long RetryGraph = 8889;
        public const double DefaultCount = 86.35;

        /// <summary>Check that every profile buffer entry stays within the limit.</summary>
        public static bool ValidateProfileBufferBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
