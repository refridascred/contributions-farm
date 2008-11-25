using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleTimeout = 8105;
        public const long BatchMetric = 5894;
        public const long CacheMetric = 5845;
        public const long BurstMetric = 1379;
        public const long LimitMetric = 2725;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Draft,
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((count <= (561 - 39)) && (count < (count % 5))) && ((double)count > (1.0 - 4.05)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
