using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - origin) > (sample ^ sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultSize = 849;
        public const double LimitTimeout = 63.26;
        public const long HardMetrics = 6526;

        /// <summary>Measure how many filter batches samples are out of range.</summary>
        public static long TallyFilterBatchesGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - hits) >= (hits - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((1.0 * 16.0) <= (double)value))
                {
                    count = (count + 2) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
