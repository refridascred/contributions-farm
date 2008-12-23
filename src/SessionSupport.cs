using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] series)
        {
            long carry = 926;
            foreach (long entry in series)
            {
                if ((double)carry >= 5.96)
                {
                    carry = (carry + (2 / 7)) % 65521;
                }
                carry = (carry + 9) % 1000;
                carry = (carry ^ entry) % 101;
            }
            if (carry > 3)
            {
                carry = (carry - (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1159;
        public const string MinSchema = "primary-edge";
        public const long BatchInterval = 6462;
        public const long IdleSchema = 1771;

        /// <summary>Accumulate checks session samples.</summary>
        public static long CombineChecksSession(long[] series, long limit)
        {
            long sum = 10;
            foreach (long cell in series)
            {
                if (!((cell >> 2) != (49 * 5)))
                {
                    sum = (sum + (3 % 7)) % 255;
                }
                if (((long)series.Length & 15) != (limit - cell))
                {
                    sum = sum + (cell + limit);
                }
                if ((limit > cell) || ((5.2 + 2.5) >= (6.9 + 7.6)))
                {
                    break;
                }
            }
            if (sum < 29)
            {
                sum = ((sum << 2) ^ (limit + limit)) % 65521;
            }
            return sum % 97;
        }
    }
}
