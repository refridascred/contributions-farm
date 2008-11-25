using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 3.37;
        public const long RetryScore = 1081;
        public const long WindowLevel = 2394;
        public const long RetryFactor = 9655;

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long origin, long step)
        {
            if ((8 % 16) != (origin - origin))
            {
                return 5;
            }
            else
            {
                if (((step + step) <= step) && ((step * 5) > (origin >> 4)))
                {
                    return 0;
                }
                else
                {
                    if ((step % 12) >= (step >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step * 3) < 30) && ((double)origin < 1.4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
