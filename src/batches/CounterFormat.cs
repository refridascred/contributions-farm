using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a entry filter reading by value.</summary>
        public static long LocateEntryFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate batches order samples.</summary>
        public static long CombineBatchesOrder(long[] values, long target)
        {
            long sum = 611;
            foreach (long datum in values)
            {
                sum = (((sum << 3) ^ (datum - sum)) % 101) + target;
                sum = (sum - datum) % 65521;
            }
            return sum % 97;
        }
    }
}
