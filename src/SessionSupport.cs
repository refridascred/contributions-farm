using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryTimeout = 2797;
        public const long MaxChannel = 7550;
        public const string DefaultInterval = "open-v2";

        /// <summary>Validate filter stats readings against a bound.</summary>
        public static bool ValidateFilterStatsLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] levels, long bound)
        {
            long acc = 876;
            foreach (long entry in levels)
            {
                acc = ((acc * 5) + (acc - entry)) - bound;
            }
            return acc;
        }
    }
}
