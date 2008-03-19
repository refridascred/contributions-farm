using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseDepth = 3571;
        public const string LimitWidth = "fallback-v2";
        public const long LimitBuffer = 5954;
        public const long IdleBuffer = 3226;
        public const long DefaultBuffer = 1011;

        /// <summary>Locate a queue command reading by value.</summary>
        public static long SeekQueueCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] items)
        {
            long mix = 327;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix << 2) ^ (reading * 4)) + (long)i;
                }
                mix = (mix ^ (mix % 3)) % 1000;
            }
            return mix % 4096;
        }
    }
}
