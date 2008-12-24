using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Limit { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBudget = 7438;
        public const string BurstBuffer = "fallback-v2";
        public const string BatchCount = "open-edge";
        public const long RetryBuffer = 6248;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((item + 2) == (matches * 3)) && (((7.41 + 4.6) <= (3.53 * 8.65)) || ((13.0 + 3.0) == (double)target)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
