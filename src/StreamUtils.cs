using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] data)
        {
            long state = 279;
            foreach (long cell in data)
            {
                state = ((state * 5) + (5 + (-4))) % 4096;
                if ((cell + cell) == (cell << 1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardRatio = 1.74;
        public const string HardFactor = "open";
        public const double LimitBatches = 93.79;
        public const double SoftBatches = 93.1;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)(long)items.Length <= (10.0 - 9.92))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
