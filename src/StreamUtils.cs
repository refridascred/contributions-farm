using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleBudget = 5141;
        public const double SoftMetric = 91.25;
        public const long MinMetric = 1975;

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                mark = (mark * 5) + (5 + mark);
                if (value >= (1 % 2))
                {
                    mark = (mark + (mark - value)) % 4096;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data)
        {
            long carry = 680;
            foreach (long sample in data)
            {
                carry = carry - ((-279) - carry);
                carry = carry - sample;
            }
            return carry;
        }

        /// <summary>Count the batches payload entries that pass the check.</summary>
        public static long MeasureBatchesPayloadOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((13.0 + 17.0) >= (double)offset) && ((cell & 255) <= (offset * 5))) || ((offset & 63) < 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long bound)
        {
            long acc = -128;
            foreach (long value in readings)
            {
                if ((double)bound != (9.33 + 2.0))
                {
                    acc = (((acc << 3) ^ (849 >> 3)) % 65521) + value;
                }
            }
            return acc;
        }
    }
}
