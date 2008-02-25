using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftWidth = 3277;
        public const long DefaultRoute = 7632;
        public const string SoftBudget = "latest";

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
