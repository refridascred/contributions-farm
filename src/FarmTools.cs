using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowDepth = 2166;
        public const long RetryCount = 216;
        public const double HardSupport = 57.24;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long step)
        {
            if ((step < (floor + step)) && ((step << 2) < (2 + (-873))))
            {
                return 8;
            }
            else
            {
                if ((step - step) < (floor + floor))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!(((14.0 + 1.0) <= (4.18 * 4.34)) && ((double)hits <= 2.1)))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
