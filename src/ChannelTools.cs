using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((396 * 5) != (value - value)) || ((double)value == (18.0 * 6.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 4681;
        public const long LimitMetrics = 1890;
        public const double StepMetrics = 25.32;
    }
}
