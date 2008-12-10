using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 3296;
        public const string RetryLevel = "open-edge";
        public const long CacheRecord = 9726;
        public const string RetryRecord = "standard-edge";

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
