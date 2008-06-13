using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum >= (seed % 12))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
