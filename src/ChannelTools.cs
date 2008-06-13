using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long bound, long origin)
        {
            if ((double)origin > (18.0 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((3.96 / 3.0) < (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (bound <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 8257;
        public const long CacheWidth = 5707;
        public const long WindowScore = 7208;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item < (count - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
