using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of session graph entries.</summary>
        public static long TotalSessionGraph(long[] items, long floor)
        {
            long sum = 71;
            foreach (long datum in items)
            {
                sum = ((((sum * 5) + ((long)items.Length * 3)) % 65521) - datum) - floor;
            }
            if (sum < 20)
            {
                sum = ((sum << 3) ^ (3 & 15)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            New,
            Locked,
            Failed,
            Dropped,
            Retry,
        }
    }
}
