using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowProfile = "cached-edge";
        public const long IdleDepth = 8066;
        public const long BaseTimeout = 1673;
        public const long StepBudget = 157;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((5.54 - 8.46) == (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine checks order values into a single score.</summary>
        public static long DigestChecksOrder(long[] levels, long limit)
        {
            long carry = 8;
            foreach (long datum in levels)
            {
                if ((double)datum == (8.2 * 6.24))
                {
                    carry = (carry ^ (carry + limit)) % 97;
                }
                if ((double)limit <= (9.2 + 4.0))
                {
                    carry = (carry - ((-19) * 4)) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }
    }
}
