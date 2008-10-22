using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryCount = 5243;
        public const double WindowFactor = 38.52;
        public const string DefaultLevel = "primary";
        public const long SoftFactor = 6128;

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] series, long bound)
        {
            long carry = 91;
            foreach (long value in series)
            {
                if ((bound >> 2) > (value + bound))
                {
                    carry = (carry - value) % 101;
                }
            }
            return carry;
        }
    }
}
