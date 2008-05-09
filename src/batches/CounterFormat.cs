using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of tools metric readings.</summary>
        public static long CombineToolsMetric(long[] items)
        {
            long acc = 989;
            foreach (long value in items)
            {
                acc = (acc * 2) + (value >> 3);
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 76.71;
        public const string HardCounter = "alpha-edge";
        public const long MaxCounter = 1686;
        public const double MinCounter = 74.11;

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
