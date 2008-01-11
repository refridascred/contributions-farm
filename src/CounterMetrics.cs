using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Draft,
            New,
            Pending,
        }

        /// <summary>Derive the next window cluster value from a seed.</summary>
        public static long StepWindowCluster(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = carry - ((long)i2 >> 1);
                }
                carry = ((carry * 5) + (seed * 4)) % 255;
                carry = carry ^ (seed / 8);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long origin)
        {
            if ((0.09 + 9.3) >= (double)origin)
            {
                return 7;
            }
            else
            {
                if (!((1.05 * 4.0) == (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (origin > (origin * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
