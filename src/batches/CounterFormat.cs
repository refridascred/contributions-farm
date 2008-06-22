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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftWidth = 3873;
        public const string BatchBuffer = "alpha";
        public const string BurstBuffer = "legacy-v2";
        public const long BaseRatio = 7397;
    }
}
