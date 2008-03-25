using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "cached-1";
        public const string LimitBudget = "latest-1";
        public const long BurstBudget = 289;
        public const string RetryBudget = "fallback-1";
        public const string RetryCommand = "primary-v2";

        /// <summary>Iterate the window graph series from a seed.</summary>
        public static long StepWindowGraph(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result - (offset + result)) % 97) + (long)i2;
                }
                long span = ((long)i / 7) % 7;
                if (!(90 >= (result + span)))
                {
                    span = (span * 4) + (result + (long)i);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
