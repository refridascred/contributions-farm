using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Count { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Retry,
            Dropped,
            Failed,
            Locked,
        }
    }
}
