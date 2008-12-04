using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] items, long target)
        {
            long mix = 761;
            foreach (long sample in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix * 3) + sample) - (long)i;
                }
                mix = ((mix * 4) + (target + mix)) % 101;
            }
            if (mix < 6)
            {
                mix = (mix << 3) ^ target;
            }
            return mix % 65521;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] samples)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                if ((double)entry == (7.3 - 2.7))
                {
                    total = (total + (50 & 1)) % 101;
                }
            }
            return total;
        }
    }
}
