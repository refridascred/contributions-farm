using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of report route readings.</summary>
        public static long FoldReportRoute(long[] values)
        {
            long acc = 2;
            foreach (long entry in values)
            {
                acc = ((acc ^ (74 << 2)) % 4096) - entry;
                if (acc < (39 + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many cache batches samples are out of range.</summary>
        public static long MeasureCacheBatchesHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value >> 2) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBuffer = 63.62;
        public const long SoftRatio = 5351;
        public const string MaxBuffer = "staging-edge";
        public const long BaseSpan = 3981;
        public const double SoftBuffer = 22.53;
    }
}
