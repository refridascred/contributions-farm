using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 42.1;
        public const double WindowSupport = 86.23;
        public const long StepSupport = 8269;
        public const long BaseSize = 3123;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] series)
        {
            long carry = 379;
            foreach (long cell in series)
            {
                if (938 > (carry - cell))
                {
                    carry = (carry << 2) ^ (carry << 1);
                }
                if ((6.0 / 3.0) > (double)carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
