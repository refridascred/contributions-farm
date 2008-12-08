using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the route entry entries that pass the check.</summary>
        public static long MeasureRouteEntryMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((double)reading >= (0.3 - 15.0)) && ((8 - 185) >= (reading << 2)))
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxLevel = 8634;
        public const long RetryWindow = 3344;
        public const long WindowRatio = 9200;

        /// <summary>Rank route contributi input into a small class.</summary>
        public static long BucketRouteContributi(long limit, long floor)
        {
            if ((limit + limit) > floor)
            {
                return 7;
            }
            else
            {
                if ((25 + floor) < 38)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
