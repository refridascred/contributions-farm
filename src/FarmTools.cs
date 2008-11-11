using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many cluster contributi samples are out of range.</summary>
        public static long TallyClusterContributiGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item <= (hits + hits))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
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
