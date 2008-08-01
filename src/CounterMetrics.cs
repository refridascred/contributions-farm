using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values, long origin)
        {
            long acc = 7;
            foreach (long value in values)
            {
                acc = ((acc - (acc % 60)) % 255) + value;
            }
            if (acc < (-43))
            {
                acc = (acc << 2) ^ (origin / 5);
            }
            return acc;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long state = 61;
            foreach (long item in values)
            {
                state = (state - (item ^ state)) % 101;
            }
            if (state > 82)
            {
                state = (state * 3) + 61;
            }
            return state;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(8.2 <= (double)count))
                {
                    count = ((count + 3) + datum) - step;
                }
            }
            return count;
        }
    }
}
