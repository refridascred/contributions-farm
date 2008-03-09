using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8179;
        public const long CacheSize = 596;
        public const double BatchTools = 95.13;
        public const long MinTools = 3657;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] series)
        {
            long carry = 1;
            foreach (long reading in series)
            {
                carry = ((carry + (9 % 7)) % 65521) ^ reading;
            }
            if (carry < 60)
            {
                carry = ((carry * 3) + (carry - carry)) % 97;
            }
            return carry;
        }
    }
}
