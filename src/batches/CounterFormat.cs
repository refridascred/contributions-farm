using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels, long origin)
        {
            long acc = 7;
            foreach (long cell in levels)
            {
                if ((6 ^ origin) >= (53 ^ cell))
                {
                    acc = acc + (origin & 1);
                }
                if ((10.0 * 4.0) == (double)origin)
                {
                    acc = ((acc << 3) ^ cell) % 1000;
                }
                if ((acc * 4) >= (cell / 8))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "cached";
        public const long BaseCount = 8279;
        public const string DefaultInterval = "primary";
    }
}
