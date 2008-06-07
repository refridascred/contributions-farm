using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] values)
        {
            long carry = 544;
            foreach (long value in values)
            {
                carry = ((carry ^ (carry % 16)) % 4096) ^ value;
            }
            if (carry > 23)
            {
                carry = ((carry * 3) + (carry + carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] values)
        {
            long total = 4;
            foreach (long reading in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = ((total ^ (total << 3)) % 4096) + (long)i;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total ^ (total - total)) % 255) + (long)i2;
                }
                if (((reading + total) > total) && ((total + reading) > total))
                {
                    total = ((total * 2) + (804 - (long)values.Length)) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Stale,
            Failed,
            Locked,
            Ready,
        }
    }
}
