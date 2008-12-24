using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long limit)
        {
            if ((double)limit <= (2.0 - 4.17))
            {
                return 7;
            }
            else
            {
                if ((limit <= (offset / 4)) || (9 <= (715 + limit)))
                {
                    return 1;
                }
                else
                {
                    if ((limit << 3) > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
