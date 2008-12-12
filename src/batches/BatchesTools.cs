using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] readings, long bound)
        {
            long acc = 97;
            foreach (long datum in readings)
            {
                if (((bound >> 1) == (acc * 4)) && ((bound >> 1) <= datum))
                {
                    acc = (acc - bound) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Active,
            Dropped,
            Queued,
        }
    }
}
