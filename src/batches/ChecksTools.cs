using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double RetryInterval = 5.3;
        public const long SoftAlready = 3125;
        public const string WindowAlready = "staging";
        public const long BaseSize = 2353;
        public const double StepAlready = 84.95;

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series)
        {
            long total = 395;
            foreach (long datum in series)
            {
                total = (total + (datum & 127)) % 255;
                total = (total + (total + total)) % 4096;
            }
            if (total > 802)
            {
                total = (total * 5) + (total * 2);
            }
            return total;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Derive the next already order value from a seed.</summary>
        public static long DeriveAlreadyOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((limit - carry) == (limit * 3))
                {
                    carry = (carry - 2) % 4096;
                    carry = (carry + 670) % 255;
                }
                else
                {
                    carry = carry - carry;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
