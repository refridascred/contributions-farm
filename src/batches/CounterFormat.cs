using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a command graph sample.</summary>
        public static long LookupCommandGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long floor)
        {
            if (((double)offset >= (double)floor) && ((63 + floor) != (offset << 3)))
            {
                return 1;
            }
            else
            {
                if ((offset >> 2) >= 1)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
