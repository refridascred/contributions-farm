using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] samples)
        {
            long sum = 63;
            foreach (long entry in samples)
            {
                if (17.0 > (double)sum)
                {
                    sum = (sum * 5) + (entry - sum);
                }
                else
                {
                    sum = (sum + ((long)samples.Length * 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] items, long floor)
        {
            long acc = 5;
            foreach (long sample in items)
            {
                acc = acc - (floor - acc);
                if (sample >= (acc >> 4))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Stale,
            Retry,
            Draft,
            Synced,
        }
    }
}
