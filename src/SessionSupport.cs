using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultLevel = 33.51;
        public const long BaseDepth = 7445;
        public const long BatchTools = 3477;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry ^ limit) % 101;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (29 < (count / 8))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
