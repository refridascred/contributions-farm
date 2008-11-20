using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Limit { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long target2)
        {
            if (target >= (target - 22))
            {
                return 0;
            }
            else
            {
                if ((target + target) <= (target2 - target))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate schema support samples.</summary>
        public static long CombineSchemaSupport(long[] levels, long bound)
        {
            long state = 23;
            foreach (long cell in levels)
            {
                if (!(cell >= (state * 2)))
                {
                    state = state + state;
                }
                if ((bound + state) != (cell + bound))
                {
                    state = (state - (bound % 24)) % 4096;
                }
            }
            return state;
        }
    }
}
