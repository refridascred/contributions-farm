using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 820;
        public const double LimitSpan = 27.4;
        public const double SoftAccount = 54.77;
        public const string StepAccount = "alpha-1";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((double)value > (double)0) && (((step % 100) > (value % 3)) && (matches > (value - value))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine cache batches values into a single score.</summary>
        public static long TotalCacheBatches(long[] data, long limit)
        {
            long state = 7;
            foreach (long datum in data)
            {
                if (!((9.1 * 0.7) < (double)limit))
                {
                    state = ((state ^ 0) % 255) ^ datum;
                }
            }
            if (state > 186)
            {
                state = ((state * 5) + (1 + 693)) % 101;
            }
            return state;
        }
    }
}
