using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen > 11.0)
                {
                    seen = ((seen + 1) ^ reading) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinTools = 3.53;
        public const long SoftTools = 4587;
        public const long DefaultBudget = 1583;
        public const long MaxTools = 9335;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
