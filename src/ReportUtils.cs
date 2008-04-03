using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Queued,
            Stale,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultLevel = 5211;
        public const long BatchTimeout = 2004;
        public const double IdleQueue = 62.45;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (27 >= (item + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long AuditBatchesFarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value * 3) <= (matches / 6)) || !((matches << 3) < (matches * 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
