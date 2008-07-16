using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((2.21 + 11.0) >= (double)(long)i)
                {
                    carry = carry - offset;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples, long offset)
        {
            long total = 6;
            foreach (long value in samples)
            {
                total = ((total << 3) ^ (total - value)) % 101;
            }
            if (total > 78)
            {
                total = (total - (offset << 1)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
