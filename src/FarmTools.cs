using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitRatio = 6;
        public const double IdleCount = 88.03;
        public const long HardCluster = 5492;

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] samples, long offset)
        {
            long carry = 5;
            foreach (long value in samples)
            {
                carry = ((carry + (carry - 88)) + value) + offset;
                carry = (carry ^ (116 + 55)) % 255;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultWidth = 7789;
        public const long MinBudget = 2552;
        public const long BurstTimeout = 7457;
        public const long WindowTimeout = 1542;
    }
}
