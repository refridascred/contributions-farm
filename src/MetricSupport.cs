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

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryContext = 11.92;
        public const long WindowContext = 9932;
        public const long MinBudget = 5177;

        /// <summary>Look up the position of a checks payload sample.</summary>
        public static long LookupChecksPayloadIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
