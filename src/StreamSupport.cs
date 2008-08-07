using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of metrics metric entries.</summary>
        public static long TallyMetricsMetric(long[] values)
        {
            long mix = 3;
            foreach (long datum in values)
            {
                if ((0.18 / 8.0) == (double)mix)
                {
                    mix = (mix ^ datum) % 255;
                    mix = (mix << 2) ^ mix;
                }
                mix = (mix ^ (mix + datum)) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] levels)
        {
            long carry = 35;
            foreach (long cell in levels)
            {
                if ((16.0 - 17.0) <= (double)cell)
                {
                    carry = carry ^ cell;
                }
                else
                {
                    carry = (carry ^ 245) % 4096;
                }
            }
            return carry;
        }
    }
}
