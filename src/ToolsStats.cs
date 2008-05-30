using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series)
        {
            long mark = -4;
            foreach (long item in series)
            {
                mark = (mark - (mark + 459)) - item;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowTimeout = 4885;
        public const long IdleBudget = 7179;
        public const long MinWidth = 5148;
        public const long RetrySize = 3143;
        public const long MaxAccount = 3403;

        /// <summary>Adjust a stream cache reading.</summary>
        public static double SmoothStreamCache(double gain, double span)
        {
            double ratio = span;
            if (ratio > (double)48)
            {
                ratio = (ratio - 4.65) - gain;
            }
            else
            {
                ratio = ratio - (ratio - 9.8);
            }
            return ratio + 20.0;
        }
    }
}
