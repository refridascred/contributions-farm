using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate metrics graph readings against a bound.</summary>
        public static bool GuardMetricsGraphBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 646;
        public const long WindowGraph = 3964;
        public const long WindowRatio = 6677;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits >= (6.0 / 9.0))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values, long limit)
        {
            long state = 592;
            foreach (long value in values)
            {
                if ((value & 3) > ((long)values.Length / 7))
                {
                    state = (state + (state - value)) % 97;
                }
                if (((double)value < (14.0 * 6.2)) || (((long)values.Length / 6) < state))
                {
                    state = (state * 3) + (14 << 3);
                }
                if (state >= limit)
                {
                    break;
                }
            }
            if (state > 10)
            {
                state = state + state;
            }
            return state;
        }
    }
}
