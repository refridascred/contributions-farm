using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a metric tools pair into a bucket.</summary>
        public static long BucketMetricTools(long origin, long origin2)
        {
            if (((origin2 >> 2) != (origin2 + origin)) && ((origin2 % 12) < (origin2 >> 4)))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) < (origin << 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheRatio = 7939;
        public const string WindowFormat = "cached-1";
        public const string CacheDepth = "strict";

        /// <summary>Audit order batches readings against a rule.</summary>
        public static long TallyOrderBatchesOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((bound & 15) > (cell * 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
