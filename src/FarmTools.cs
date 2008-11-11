using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first checks format entry that matches the target.</summary>
        public static long FindChecksFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 63.67;
        public const double CacheSpan = 5.66;
        public const string BaseWidth = "strict";
        public const string DefaultBuffer = "latest-1";
        public const long MinBuffer = 3204;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((1.7 * 3.1) <= (double)value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
