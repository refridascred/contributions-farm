using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long bound, long origin)
        {
            long step = bound + origin;
            if (!((double)43 >= (double)step))
            {
                return 0;
            }
            else
            {
                if (!((bound - bound) > origin))
                {
                    return 5;
                }
                else
                {
                    if ((step + 168) >= (bound + 625))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)limit == (8.52 / 9.0))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
