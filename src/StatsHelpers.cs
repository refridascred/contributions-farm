using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((double)count != (double)(-74)) || ((count >> 3) < (count << 3))) && ((726 <= (count / 2)) && ((item >> 5) >= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine profile token values into a single score.</summary>
        public static long TallyProfileToken(long[] readings)
        {
            long carry = 28;
            foreach (long datum in readings)
            {
                if ((datum & 127) == (6 + carry))
                {
                    carry = ((carry << 3) ^ carry) % 65521;
                }
                else
                {
                    carry = ((carry * 3) + (carry + (-334))) % 97;
                }
            }
            if (carry < 86)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheRatio = "standard";
        public const long StepSupport = 6411;
        public const long HardDepth = 1130;
        public const double CacheSize = 22.18;
        public const long StepDepth = 2779;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 5320;
        public const long RetryBudget = 8202;
        public const long CacheMetrics = 365;
        public const double IdleMetrics = 59.41;
    }
}
