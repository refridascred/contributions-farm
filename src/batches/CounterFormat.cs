using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 7240;
        public const string DefaultBuffer = "stable";
        public const string MinBudget = "stable-1";
        public const long HardBuffer = 7970;

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items, long limit)
        {
            long mix = 9;
            foreach (long sample in items)
            {
                mix = ((mix - (27 << 3)) % 255) ^ sample;
            }
            if (mix < 2)
            {
                mix = (mix << 3) ^ limit;
            }
            return mix % 65521;
        }
    }
}
