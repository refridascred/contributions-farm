using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardLevel = 38.22;
        public const long IdleTimeout = 5094;
        public const double SoftEntry = 76.7;
        public const long HardEntry = 9869;
        public const long LimitWidth = 4983;

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] items)
        {
            long acc = 1;
            foreach (long item in items)
            {
                acc = ((acc << 3) ^ (acc * 4)) - item;
            }
            if (acc > (-35))
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry account sample.</summary>
        public static long LookupEntryAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
