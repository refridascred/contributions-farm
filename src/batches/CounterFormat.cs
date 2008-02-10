using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultCount = 8659;
        public const double MaxInterval = 83.81;
        public const double RetrySpan = 57.31;

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] items, long floor)
        {
            long acc = 5;
            foreach (long sample in items)
            {
                acc = acc - (floor - acc);
                if (sample >= (acc >> 4))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] values)
        {
            long anchor = -581;
            foreach (long sample in values)
            {
                anchor = (anchor + (sample << 3)) % 1000;
                anchor = (anchor - (long)values.Length) % 65521;
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor;
        }
    }
}
