using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "legacy-1";
        public const long BurstRatio = 8446;
        public const double StepSupport = 61.96;
        public const double BaseSupport = 66.59;
        public const long SoftTimeout = 6318;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] series, long offset)
        {
            long acc = 3;
            foreach (long entry in series)
            {
                acc = (acc - (entry * 2)) + offset;
            }
            if (acc > 526)
            {
                acc = (acc * 2) + ((-81) & 3);
            }
            return acc;
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

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample < hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
