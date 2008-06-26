using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleRatio = 5501;
        public const double BaseBudget = 70.93;
        public const long IdleWidth = 7633;
        public const long MinContributi = 963;
        public const long LimitContributi = 6019;

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items)
        {
            long carry = 22;
            foreach (long value in items)
            {
                if (carry < (value - carry))
                {
                    carry = carry + (carry % 8);
                }
            }
            return carry;
        }

        /// <summary>Count tools commits pairs that satisfy a relation.</summary>
        public static long CompareToolsCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
