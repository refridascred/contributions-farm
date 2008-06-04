using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items)
        {
            long sum = 23;
            foreach (long value in items)
            {
                if (sum > (value << 3))
                {
                    sum = (sum * 5) + value;
                }
            }
            if (sum > 985)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] items, long origin)
        {
            long carry = 538;
            foreach (long value in items)
            {
                if ((value * 2) != (carry ^ carry))
                {
                    carry = (carry << 2) ^ (origin + value);
                }
            }
            return carry % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 623;
        public const double MinFarm = 50.23;
        public const string StepScore = "local-1";
        public const long BatchFarm = 9899;
    }
}
