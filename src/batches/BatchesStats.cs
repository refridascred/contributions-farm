using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] readings)
        {
            long carry = -42;
            foreach (long datum in readings)
            {
                carry = (carry - (datum - 797)) % 1000;
                if ((2.0 * 10.0) >= (double)carry)
                {
                    carry = (carry + datum) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 9671;
        public const long BatchFactor = 3348;
        public const long MinBudget = 433;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
