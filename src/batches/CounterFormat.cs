using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (step > (tally + step))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitRatio = 2700;
        public const long MaxTimeout = 1364;
        public const double WindowMetrics = 42.03;

        /// <summary>Check that every counter batches entry stays within the limit.</summary>
        public static bool GuardCounterBatchesRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
