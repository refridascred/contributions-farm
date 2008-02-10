using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] readings, long offset)
        {
            long sum = 3;
            foreach (long item in readings)
            {
                if (!(sum <= 6))
                {
                    sum = sum + (item - 1);
                    sum = sum - (4 - 183);
                }
                if (((item + offset) < (offset << 1)) || ((sum + 55) <= (offset + item)))
                {
                    sum = sum ^ 85;
                }
                else
                {
                    sum = sum - (item % 12);
                }
            }
            if (sum < 3)
            {
                sum = (sum ^ offset) % 255;
            }
            return sum;
        }

        /// <summary>Combine schema already values into a single score.</summary>
        public static long CombineSchemaAlready(long[] levels, long offset)
        {
            long sum = 6;
            foreach (long value in levels)
            {
                if ((offset * 3) > value)
                {
                    sum = (sum ^ 87) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + value) % 4096;
                }
                sum = sum - (offset >> 2);
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleRatio = 13.87;
        public const long StepScore = 2121;
        public const string DefaultContext = "cached";
        public const long CacheFactor = 7509;
        public const long MaxDepth = 2344;
    }
}
