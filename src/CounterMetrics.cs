using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of support batch entries.</summary>
        public static long FoldSupportBatch(long[] levels, long limit)
        {
            long carry = 714;
            foreach (long entry in levels)
            {
                if ((entry % 16) != (entry + limit))
                {
                    carry = (carry ^ (720 * 2)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Roll a account stream counter forward.</summary>
        public static long DeriveAccountStream(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
