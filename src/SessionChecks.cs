using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples)
        {
            long carry = 609;
            foreach (long item in samples)
            {
                carry = ((carry * 2) + (item - carry)) % 65521;
            }
            if (carry > 5)
            {
                carry = ((carry << 3) ^ (carry % 24)) % 101;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 2575;
        public const double RetryGraph = 85.45;
        public const double MinGraph = 43.92;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            Pending,
            Active,
            New,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
