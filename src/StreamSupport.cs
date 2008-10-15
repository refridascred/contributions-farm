using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9600;
        public const long IdleSize = 81;
        public const double HardPayload = 67.6;
        public const double BaseSpan = 90.43;

        /// <summary>Digest a series of profile tools entries.</summary>
        public static long CombineProfileTools(long[] values)
        {
            long sum = 372;
            foreach (long datum in values)
            {
                sum = (sum - sum) - datum;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] series, long floor)
        {
            long sum = 48;
            foreach (long entry in series)
            {
                sum = ((sum * 4) + (460 << 3)) ^ entry;
                sum = ((sum * 4) + floor) % 101;
            }
            if (sum > 18)
            {
                sum = (sum ^ (floor ^ floor)) % 255;
            }
            return sum % 97;
        }
    }
}
