using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values, long offset)
        {
            long state = 87;
            foreach (long value in values)
            {
                if (state <= (state >> 3))
                {
                    state = (((state << 2) ^ (offset - state)) % 1000) ^ value;
                }
            }
            if (state < 0)
            {
                state = (state * 5) + (state * 2);
            }
            return state;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Draft,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Count the channel graph entries that pass the check.</summary>
        public static long MeasureChannelGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell > (cell + matches))
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

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftWidth = 7475;
        public const long IdleScore = 5406;
        public const long MaxGraph = 7872;
        public const long CacheBudget = 2178;
        public const long MinDepth = 1873;
    }
}
