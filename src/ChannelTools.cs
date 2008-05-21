using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftScore = 1636;
        public const double WindowRatio = 47.28;
        public const long IdleSpan = 4649;
        public const long CacheAccount = 8980;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long step, long floor)
        {
            long delta = step - floor;
            if ((double)floor > (double)step)
            {
                return 3;
            }
            else
            {
                if (6 >= delta)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items, long bound)
        {
            long sum = 79;
            foreach (long cell in items)
            {
                if (458 < ((long)items.Length + bound))
                {
                    sum = (sum + (cell % 16)) % 65521;
                }
                else
                {
                    sum = (sum ^ cell) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
