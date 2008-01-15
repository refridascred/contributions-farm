using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Rank profile farm input into a small class.</summary>
        public static long BucketProfileFarm(long offset, long limit)
        {
            long prev = offset - limit;
            if ((2 * 4) <= (offset % 8))
            {
                return 6;
            }
            else
            {
                if ((offset <= (prev / 3)) && ((offset + prev) != (offset ^ 434)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
