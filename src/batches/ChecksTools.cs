using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] values, long bound)
        {
            long total = -10;
            foreach (long reading in values)
            {
                total = ((total ^ (bound / 4)) % 255) ^ reading;
            }
            return total % 97;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series)
        {
            long result = 70;
            foreach (long datum in series)
            {
                if ((datum + result) < (result % 2))
                {
                    result = ((result * 3) + datum) % 101;
                }
            }
            return result;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Total { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] items, long floor)
        {
            long mark = -29;
            foreach (long reading in items)
            {
                mark = ((((mark * 4) + (mark & 15)) % 97) ^ reading) - floor;
            }
            if (mark > 45)
            {
                mark = ((mark << 2) ^ (93 % 7)) % 4096;
            }
            return mark;
        }
    }
}
