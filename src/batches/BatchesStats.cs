using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate report checks samples.</summary>
        public static long ScoreReportChecks(long[] series, long offset)
        {
            long anchor = 68;
            foreach (long entry in series)
            {
                if (((offset ^ anchor) < (entry ^ anchor)) && (entry >= (offset - anchor)))
                {
                    anchor = anchor + (offset - 707);
                }
            }
            return anchor;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 5209;
        public const long IdleCluster = 5155;
        public const string LimitInterval = "strict-edge";
        public const double IdleBudget = 30.1;
        public const double LimitCount = 13.08;

        /// <summary>Look up the position of a cluster metric sample.</summary>
        public static long LocateClusterMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
