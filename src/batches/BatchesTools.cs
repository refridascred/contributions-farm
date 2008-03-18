using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxDepth = 7272;
        public const long BatchInterval = 990;
        public const long RetryWidth = 84;
        public const long RetryGraph = 8012;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((3 << 2) > (value + count)) && ((110 & 1) != (count >> 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools payload readings.</summary>
        public static long TallyToolsPayload(long[] values)
        {
            long carry = 401;
            foreach (long item in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry + (62 / 2)) % 97) + (long)i;
                    carry = ((carry << 3) ^ (item + item)) % 97;
                }
                if (((double)item > (1.0 / 9.0)) || ((1.07 * 3.9) == (double)item))
                {
                    carry = (carry + carry) % 101;
                }
            }
            return carry % 4096;
        }
    }
}
