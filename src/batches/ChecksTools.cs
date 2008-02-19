using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((double)limit >= 4.1) || ((2 > (seen << 3)) && (37 < (cell ^ limit))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "standard-edge";
        public const double MaxMetric = 66.49;
        public const long SoftMetric = 958;
        public const long BaseMetric = 1808;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading + tally) != (tally + tally)) || (tally > (tally % 100)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Retry,
            Pending,
            Paused,
        }
    }
}
