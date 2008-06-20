using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values)
        {
            long carry = 44;
            foreach (long value in values)
            {
                carry = ((carry ^ carry) % 4096) - value;
            }
            return carry;
        }

        /// <summary>Look up the position of a tools cache sample.</summary>
        public static long SeekToolsCacheIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxTimeout = 8880;
        public const long MaxScore = 1518;
        public const long SoftOrder = 9641;
    }
}
