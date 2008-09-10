using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double CacheLevel = 90.68;
        public const long WindowReport = 4114;
        public const long CacheInterval = 494;

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values, long step)
        {
            long anchor = 83;
            foreach (long entry in values)
            {
                if (56 >= (entry & 3))
                {
                    anchor = anchor - (9 << 3);
                }
                if ((anchor + step) >= step)
                {
                    anchor = ((anchor * 2) + (anchor - entry)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long carry = 6;
            foreach (long reading in series)
            {
                if ((1.89 * 19.0) > (double)carry)
                {
                    carry = (carry - (reading + carry)) % 65521;
                }
            }
            if (carry < 74)
            {
                carry = (carry + (5 & 255)) % 97;
            }
            return carry % 65521;
        }
    }
}
