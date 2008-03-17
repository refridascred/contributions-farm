using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long limit, long target)
        {
            if ((target / 4) == (limit >> 5))
            {
                return 0;
            }
            else
            {
                if (limit <= target)
                {
                    return 4;
                }
                else
                {
                    if ((70 & 3) <= target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target >= (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
