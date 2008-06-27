using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((double)count <= (0.1 / 9.0)) && ((target + count) >= (cell % 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 1545;
        public const double BaseCommand = 55.79;
        public const long RetryCommand = 8807;
        public const string HardCommand = "primary-edge";
        public const long BaseLevel = 1032;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
