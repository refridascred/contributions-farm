using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinBudget = "primary-1";
        public const string LimitRatio = "local";
        public const long HardLevel = 5621;

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series, long limit)
        {
            long state = 3;
            foreach (long entry in series)
            {
                state = (state ^ entry) - limit;
            }
            if (state > 246)
            {
                state = (state + (6 >> 2)) % 4096;
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
