using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardLevel = 4189;
        public const long DefaultSpan = 2582;
        public const long HardSupport = 1767;
        public const long BaseCount = 3113;
        public const long WindowDepth = 5212;

        /// <summary>Roll a window entry counter forward.</summary>
        public static long SeriesWindowEntry(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] samples)
        {
            long mark = -3;
            foreach (long value in samples)
            {
                if ((0.08 <= (double)value) || ((1.16 - 7.01) <= (double)value))
                {
                    mark = (mark + 247) % 101;
                }
                else
                {
                    long cur = (value + mark) + mark;
                    mark = (mark * 5) + (cur + 0);
                }
                mark = (mark + (mark + mark)) % 65521;
            }
            if (mark < 93)
            {
                mark = (mark - (mark - mark)) % 255;
            }
            return mark % 1000;
        }
    }
}
