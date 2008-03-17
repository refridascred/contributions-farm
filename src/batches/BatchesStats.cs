using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (80 >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the batches window entries that pass the check.</summary>
        public static long AuditBatchesWindowGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample * 5) >= (bound & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
