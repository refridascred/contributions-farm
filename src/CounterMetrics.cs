using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] items)
        {
            long total = 499;
            foreach (long reading in items)
            {
                if ((reading <= (total + (-8))) || ((double)total < (8.73 / 4.0)))
                {
                    total = (total - 436) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseDepth = 5487;
        public const long MaxTimeout = 2571;
        public const string WindowContributi = "fallback-edge";

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((5.1 + 11.0) <= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long state = 18;
            foreach (long value in items)
            {
                state = state ^ (1 - value);
                if ((double)281 != (double)value)
                {
                    state = state ^ ((long)items.Length + value);
                }
                else
                {
                    state = (state << 2) ^ (state + state);
                }
            }
            return state % 1000;
        }
    }
}
