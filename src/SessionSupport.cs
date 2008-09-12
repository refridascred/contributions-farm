using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 6808;
        public const double SoftTools = 32.94;
        public const long HardTools = 963;
        public const double MinTools = 92.13;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 4538;
        public const string RetryCounter = "strict-1";
        public const string MinBudget = "fallback-1";
        public const long DefaultInterval = 166;

        /// <summary>Validate graph metric readings against a bound.</summary>
        public static bool CheckGraphMetricRange(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
