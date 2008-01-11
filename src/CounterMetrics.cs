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

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] data)
        {
            long mix = 0;
            foreach (long value in data)
            {
                if (!((value - mix) == (14 >> 4)))
                {
                    mix = (mix ^ (mix + value)) % 4096;
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix % 4096;
        }
    }
}
