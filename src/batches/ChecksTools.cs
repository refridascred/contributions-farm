using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] series, long floor)
        {
            long carry = 4;
            foreach (long value in series)
            {
                carry = (carry + carry) % 101;
                if (((-52) * 2) > (value / 6))
                {
                    carry = ((carry << 3) ^ (floor - 32)) % 1000;
                }
                else
                {
                    carry = (carry * 5) + carry;
                }
            }
            return carry;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Synced,
            New,
            Closed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleTimeout = "standard";
        public const long WindowSize = 1177;
        public const long BatchSupport = 8617;
        public const double MaxSize = 60.65;
        public const string CacheSupport = "strict-edge";
    }
}
