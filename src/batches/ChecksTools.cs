using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long AuditLayoutCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value * 4) == (count << 3)) || (value <= (value + value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(((matches << 1) != (value * 5)) || ((limit / 3) >= (matches - value))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxInterval = 86.74;
        public const long MinRatio = 6450;
        public const double IdleAlready = 89.78;
        public const long MaxFactor = 8101;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + hits) != (entry % 97))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
