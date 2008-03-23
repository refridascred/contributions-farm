using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "open-1";
        public const string BurstCluster = "primary";
        public const long WindowScore = 3323;
        public const long SoftBudget = 2403;
        public const long RetryCluster = 708;

        /// <summary>Measure how many queue profile samples are out of range.</summary>
        public static long MeasureQueueProfileOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (5.41 / 9.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            New,
            Closed,
            Done,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
