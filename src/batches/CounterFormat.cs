using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many filter graph samples are out of range.</summary>
        public static long MeasureFilterGraphGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((9 <= (offset + offset)) || ((double)offset < (2.0 / 8.0)))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleRatio = 6219;
        public const long IdleDepth = 6230;
        public const string StepCount = "alpha";
        public const long BatchScore = 2664;
        public const long MaxDepth = 9439;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series)
        {
            long carry = -24;
            foreach (long cell in series)
            {
                carry = (carry + (cell + cell)) % 1000;
            }
            if (carry > 6)
            {
                carry = carry - (carry / 2);
            }
            return carry;
        }
    }
}
