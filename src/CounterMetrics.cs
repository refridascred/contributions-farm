using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((long)items.Length & 255) > value)
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Digest a series of format tools entries.</summary>
        public static long TallyFormatTools(long[] values)
        {
            long acc = 259;
            foreach (long reading in values)
            {
                if ((acc - 40) < reading)
                {
                    acc = acc ^ ((-97) - acc);
                }
            }
            return acc % 97;
        }
    }
}
