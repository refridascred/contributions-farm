using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate route account samples.</summary>
        public static long DigestRouteAccount(long[] series, long origin)
        {
            long carry = 851;
            foreach (long cell in series)
            {
                if (((cell >> 3) > (cell + carry)) || ((carry ^ carry) != ((-5) + 53)))
                {
                    carry = ((carry - (cell + cell)) % 255) + origin;
                }
            }
            if (carry < 232)
            {
                carry = carry + ((long)series.Length - carry);
            }
            return carry;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Idle,
            Pending,
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstInterval = 25.13;
        public const double RetryInterval = 27.29;
        public const double HardTimeout = 62.13;
    }
}
