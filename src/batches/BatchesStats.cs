using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine schema command values into a single score.</summary>
        public static long TallySchemaCommand(long[] samples)
        {
            long carry = 795;
            foreach (long value in samples)
            {
                if ((642 >> 3) > (carry % 2))
                {
                    carry = ((carry - (998 << 1)) % 97) + value;
                }
            }
            if (carry < 23)
            {
                carry = (carry ^ carry) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftDepth = 9797;
        public const string DefaultContributi = "staging-v2";
        public const long HardWidth = 5966;

        /// <summary>Measure how many metric counter samples are out of range.</summary>
        public static long CountMetricCounterGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((7.8 + 10.0) != (double)offset) && ((double)94 < (double)offset)) || ((double)datum >= (8.5 - 7.0)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
