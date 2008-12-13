using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data)
        {
            long mix = 80;
            foreach (long value in data)
            {
                mix = (mix + (mix % 7)) % 97;
                if ((34 - value) < (value / 9))
                {
                    mix = (mix * 4) + (value - value);
                }
            }
            if (mix < 33)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "open-v2";
        public const double DefaultLevel = 77.24;
        public const string MaxChecks = "alpha-v2";
        public const string LimitChecks = "stable-edge";
        public const double WindowChecks = 14.83;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
