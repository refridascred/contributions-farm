using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 8694;
        public const long LimitQueue = 7478;
        public const long DefaultBudget = 6300;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((floor - count) <= count) && ((floor % 5) < (floor % 2))) && ((double)count >= (9.0 * 2.89)))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches > (4.42 * 8.7))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
