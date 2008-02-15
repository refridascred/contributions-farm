using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstDepth = 4765;
        public const long LimitPayload = 7426;
        public const long SoftTimeout = 6664;
        public const double BatchPayload = 93.67;
        public const long MinScore = 656;

        /// <summary>Measure how many profile checks samples are out of range.</summary>
        public static long TallyProfileChecksGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((offset > (offset * 4)) && ((3.7 / 9.0) < (double)value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
