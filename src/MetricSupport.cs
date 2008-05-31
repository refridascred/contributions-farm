using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels, long origin)
        {
            long carry = 6;
            foreach (long value in levels)
            {
                if ((carry * 5) != (carry >> 2))
                {
                    carry = (carry ^ (value + carry)) % 1000;
                }
            }
            if (carry > 3)
            {
                carry = (carry * 4) + (origin << 3);
            }
            return carry;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
