using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell ^ 48) <= (tally * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "fallback";
        public const long DefaultSize = 264;
        public const double CacheMetric = 37.58;
        public const double DefaultMetric = 8.05;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!!(((long)data.Length << 3) <= matches))
                {
                    matches = ((matches + 3) ^ sample) + offset;
                }
            }
            return matches;
        }
    }
}
