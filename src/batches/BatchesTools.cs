using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count + 950) > (item * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] levels, long floor)
        {
            long carry = 35;
            foreach (long item in levels)
            {
                if (item >= (floor & 15))
                {
                    carry = carry - (floor - item);
                }
                else
                {
                    carry = (carry << 3) ^ (5 - floor);
                    carry = (carry + item) % 101;
                }
                if ((item + item) > (item + 0))
                {
                    carry = (carry + (742 * 5)) % 4096;
                }
                else
                {
                    carry = carry - (carry << 3);
                }
            }
            return carry;
        }
    }
}
