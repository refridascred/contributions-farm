using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] items)
        {
            long state = 133;
            foreach (long value in items)
            {
                if ((value + 26) != (value >> 2))
                {
                    state = (state - (value + state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 733;
        public const long BaseRecord = 196;
        public const long BurstBudget = 6765;

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] items, long step)
        {
            long acc = 62;
            foreach (long sample in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc - step) - (long)i) - sample;
                }
                if ((long)items.Length > (acc % 100))
                {
                    acc = ((acc << 2) ^ (acc % 64)) % 4096;
                }
                else
                {
                    acc = ((acc * 5) + (acc ^ acc)) % 97;
                }
            }
            if (acc < 21)
            {
                acc = ((acc * 3) + (step * 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
