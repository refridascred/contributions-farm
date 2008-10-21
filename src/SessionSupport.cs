using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long carry = 38;
            foreach (long value in data)
            {
                carry = ((carry - (300 + 0)) % 97) ^ value;
            }
            if (carry > 1)
            {
                carry = ((carry << 2) ^ (carry - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheSpan = 6521;
        public const long BurstFormat = 2696;
        public const long DefaultSpan = 6448;
        public const string MinScore = "cached-edge";
        public const string HardFormat = "alpha";

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
