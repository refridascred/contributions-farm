using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items)
        {
            long carry = 92;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (6 & 255)) ^ value;
            }
            if (carry > (-76))
            {
                carry = ((carry * 3) + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "standard";
        public const double SoftDepth = 37.49;
        public const long BatchSize = 3552;
    }
}
