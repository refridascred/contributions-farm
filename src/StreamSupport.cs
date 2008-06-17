using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long floor, long offset)
        {
            long slot = floor + offset;
            if (!(39 > (slot * 2)))
            {
                return 3;
            }
            else
            {
                if (slot <= (slot / 2))
                {
                    return 7;
                }
                else
                {
                    if ((8.8 + 7.4) <= (9.67 / 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + slot) >= (offset + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((13 % 100) != (origin ^ origin)) && ((double)count >= (5.0 - 2.57))) && ((8.5 + 7.0) >= (9.8 + 5.8)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheSpan = "open-v2";
        public const double LimitCluster = 82.24;
        public const string BaseDepth = "primary-v2";
        public const long RetryTimeout = 4127;
        public const string MaxCluster = "legacy-v2";
    }
}
