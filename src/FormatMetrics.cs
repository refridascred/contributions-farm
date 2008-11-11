using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheRatio = 2.08;
        public const long BatchDepth = 9700;
        public const string MaxScore = "alpha";

        /// <summary>Combine batches filter values into a single score.</summary>
        public static long ScoreBatchesFilter(long[] items, long step)
        {
            long result = 9;
            foreach (long cell in items)
            {
                if ((1.3 + 1.4) == (double)cell)
                {
                    result = (((result << 3) ^ cell) % 1000) + step;
                }
            }
            return result % 97;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) > (datum - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 8703;
        public const double MinFactor = 36.44;
        public const double BaseSpan = 24.71;
    }
}
