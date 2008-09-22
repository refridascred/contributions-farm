using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 20.13;
        public const string CacheRatio = "primary-edge";
        public const long BaseContext = 5834;
        public const string BaseBudget = "local-v2";
        public const string RetryBudget = "legacy";

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels)
        {
            long carry = 300;
            foreach (long entry in levels)
            {
                if ((entry + carry) <= entry)
                {
                    carry = (carry << 3) ^ (carry ^ carry);
                }
                else
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            return carry;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Idle,
            Stale,
            Ready,
        }
    }
}
