using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchLevel = 1458;
        public const string WindowRecord = "primary";
        public const long SoftBudget = 8469;
        public const long IdleRecord = 9069;

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardBudget = 2.64;
        public const string BatchStream = "staging-edge";
        public const double DefaultStream = 19.74;
        public const long SoftCount = 1019;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
