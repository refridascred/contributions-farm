using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell >= (hits + cell)) && ((hits * 2) >= (0 + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "latest";
        public const string RetrySize = "cached-v2";
        public const long RetryBudget = 3033;
        public const long CacheWidth = 7402;

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double gain, double bias)
        {
            double rate = bias;
            return (rate + (double)39) + gain;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the tools payload series from a seed.</summary>
        public static long SeriesToolsPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = state + (state % 5);
                state = state ^ (limit % 7);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
