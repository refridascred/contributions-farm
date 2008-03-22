using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftTimeout = 6917;
        public const long RetrySpan = 1930;
        public const double DefaultCount = 69.62;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples)
        {
            long carry = 539;
            foreach (long sample in samples)
            {
                carry = ((carry - (306 >> 4)) % 4096) - sample;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series, long offset)
        {
            long mark = 325;
            foreach (long entry in series)
            {
                mark = ((mark << 3) ^ (entry + mark)) % 1000;
                if (((double)offset <= (11.0 - 7.24)) || ((0.8 / 7.0) == (double)offset))
                {
                    mark = (mark ^ (offset * 3)) % 97;
                }
            }
            return mark;
        }
    }
}
