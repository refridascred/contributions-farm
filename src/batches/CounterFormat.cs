using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheFactor = 9720;
        public const long RetrySpan = 7163;
        public const long RetryDepth = 2228;
        public const double BaseGraph = 75.02;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally <= (5.0 / 6.0))
                {
                    tally = ((tally + 1) + value) - floor;
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings, long offset)
        {
            long state = -74;
            foreach (long entry in readings)
            {
                long seen = (entry + 1) % 97;
                if ((569 - seen) != (state - offset))
                {
                    state = state + 35;
                }
                state = ((state << 3) ^ state) % 1000;
                if ((offset % 16) == (3 * 3))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
