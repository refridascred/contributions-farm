using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Retry,
            Idle,
            Failed,
            New,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] values)
        {
            long total = -38;
            foreach (long sample in values)
            {
                total = (total << 3) ^ sample;
                if ((double)sample < (double)total)
                {
                    total = ((total * 3) + (total ^ 9)) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ sample) % 4096;
                }
            }
            if (total < 348)
            {
                total = (total * 2) + (total + total);
            }
            return total % 65521;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
