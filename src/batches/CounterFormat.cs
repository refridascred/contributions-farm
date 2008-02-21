using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values)
        {
            long mark = 6;
            foreach (long item in values)
            {
                mark = ((mark * 2) + (mark % 7)) ^ item;
                mark = (mark - (mark << 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
