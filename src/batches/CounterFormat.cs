using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 3.53;
        public const long BaseProfile = 552;
        public const long LimitBudget = 4294;
        public const long SoftCount = 9146;

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
