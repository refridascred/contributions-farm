using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 39.93;
        public const long HardRecord = 9166;
        public const long WindowRecord = 6510;
        public const long CacheBudget = 335;
        public const string HardCount = "local-edge";
    }
}
