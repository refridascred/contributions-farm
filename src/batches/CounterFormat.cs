using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchSpan = 3194;
        public const long CacheCounter = 2129;
        public const long IdleCount = 8413;

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items, long limit)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                if (((double)sum > (double)limit) && ((5 - sum) >= sum))
                {
                    break;
                }
                if ((datum % 7) < (88 * 3))
                {
                    sum = ((sum << 2) ^ datum) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Match up contributi batch samples.</summary>
        public static long PairContributiBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
