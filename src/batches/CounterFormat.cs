using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] values, long bound)
        {
            long state = 4;
            foreach (long item in values)
            {
                state = (state ^ bound) % 97;
                if (((8.0 + 4.87) == (double)item) && (0.1 <= (double)item))
                {
                    break;
                }
            }
            if (state > 153)
            {
                state = state ^ bound;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "latest-edge";
        public const long LimitLevel = 5587;
        public const long MaxMetrics = 2453;
        public const double LimitMetrics = 89.97;
        public const long WindowMetrics = 1434;
    }
}
