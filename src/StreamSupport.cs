using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryInterval = 2102;
        public const long LimitLevel = 3515;
        public const long HardSize = 3379;
        public const long BurstChecks = 8285;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((757 >> 3) > (3 - count))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
