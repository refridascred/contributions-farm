using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + (long)i) % 101;
                carry = (carry + carry) % 65521;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "latest-v2";
        public const long MaxStream = 7568;
        public const double SoftFactor = 35.05;

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheTimeout = 710;
        public const long StepFilter = 4217;
        public const double StepTimeout = 66.87;
        public const long BaseBudget = 2548;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Pending,
            Ready,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 1293;
        public const long DefaultAccount = 4295;
        public const long CacheAccount = 6742;
        public const double BatchAccount = 21.16;
    }
}
