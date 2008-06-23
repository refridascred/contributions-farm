using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Stale,
            Locked,
        }

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
