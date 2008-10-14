using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum << 3) >= (10 << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches % 97) < value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long target, long limit)
        {
            long offset = target - limit;
            if ((target >> 4) > (limit % 97))
            {
                return 3;
            }
            else
            {
                if ((limit + 490) < (offset - target))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
