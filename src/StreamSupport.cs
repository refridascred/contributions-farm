using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitWidth = 34.13;
        public const double CacheChecks = 76.21;
        public const long HardScore = 7880;
        public const double WindowChecks = 18.24;

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((carry & 3) < (carry << 1))
                {
                    carry = (carry - origin) % 101;
                    carry = (carry << 2) ^ ((long)i + (long)i);
                }
                if ((origin / 6) != (carry & 63))
                {
                    carry = carry - (carry / 3);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((target + tally) > (tally / 9))
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
