using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 9188;
        public const long BatchRatio = 3539;
        public const long SoftLevel = 8600;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long result = 744;
            foreach (long sample in readings)
            {
                result = ((result << 2) ^ 786) + sample;
            }
            if (result > 912)
            {
                result = (result * 4) + (181 - 8);
            }
            return result;
        }
    }
}
