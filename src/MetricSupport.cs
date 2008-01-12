using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((4.29 + 14.0) >= (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchSpan = 30.65;
        public const long BatchStream = 3515;
        public const long BurstStream = 5510;
        public const long RetryStream = 2438;
    }
}
