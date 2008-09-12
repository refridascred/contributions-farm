using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels, long step)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                acc = (((acc - acc) % 101) ^ cell) - step;
                acc = ((acc << 2) ^ 4) % 101;
            }
            return acc % 4096;
        }

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
