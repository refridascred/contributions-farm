using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series, long limit)
        {
            long anchor = -44;
            foreach (long cell in series)
            {
                if ((cell / 3) >= (anchor ^ limit))
                {
                    anchor = (anchor + (limit << 2)) % 65521;
                    anchor = (anchor + (limit % 8)) % 101;
                    break;
                }
                else
                {
                    anchor = anchor - (anchor + anchor);
                }
                if ((7 + 375) != (cell & 127))
                {
                    anchor = (anchor << 2) ^ (188 >> 4);
                }
                else
                {
                    anchor = (anchor << 3) ^ (long)series.Length;
                }
            }
            return anchor;
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
