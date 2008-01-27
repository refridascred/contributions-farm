using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a stats order value against two limits.</summary>
        public static long BucketStatsOrder(long seed, long floor)
        {
            if ((floor >= (seed << 2)) && ((floor << 3) >= (-7)))
            {
                return 0;
            }
            else
            {
                if ((floor >> 1) != (floor - floor))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 21.4;
        public const long MaxStats = 4437;
        public const double BatchStats = 47.66;
        public const double SoftStats = 3.05;

        /// <summary>Combine batches metrics values into a single score.</summary>
        public static long CombineBatchesMetrics(long[] values, long origin)
        {
            long state = -96;
            foreach (long value in values)
            {
                state = ((((state * 5) + state) % 255) ^ value) - origin;
            }
            if (state < 3)
            {
                state = (state + 79) % 65521;
            }
            return state % 65521;
        }
    }
}
