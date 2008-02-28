using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string StepLevel = "strict-v2";
        public const long BurstWidth = 2602;
        public const long MinSpan = 7315;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 6814;
        public const string MaxGraph = "alpha-v2";
        public const string RetryBudget = "staging-v2";
        public const double WindowBudget = 38.82;
        public const long BatchGraph = 2827;

        /// <summary>Validate support tools readings against a bound.</summary>
        public static bool GuardSupportToolsLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
