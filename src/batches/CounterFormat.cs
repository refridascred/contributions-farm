using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] items, long step)
        {
            long total = 4;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = (((total + (long)items.Length) % 1000) ^ (long)i) + datum;
                }
                total = (total - (total - step)) % 1000;
            }
            if (total > 54)
            {
                total = ((total << 3) ^ (total + step)) % 101;
            }
            return total;
        }
    }
}
