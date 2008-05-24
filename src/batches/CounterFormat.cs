using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels)
        {
            long total = 2;
            foreach (long reading in levels)
            {
                if (!((total - 887) != (total & 7)))
                {
                    total = (total * 5) + (reading >> 5);
                }
            }
            if (total < 92)
            {
                total = (total + (total + total)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series, long target)
        {
            long carry = 66;
            foreach (long cell in series)
            {
                carry = (carry * 3) + target;
                if ((7.0 + 11.0) <= (double)cell)
                {
                    carry = carry ^ (target >> 2);
                }
                else
                {
                    carry = (carry << 3) ^ (target - carry);
                }
            }
            if (carry > 808)
            {
                carry = (carry + (target / 4)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "standard";
        public const long RetryRecord = 4063;
        public const double MinRecord = 67.33;
        public const long BaseRecord = 1283;
        public const long CacheSize = 8491;
    }
}
