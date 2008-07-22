using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (seed >= (seed % 64))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Validate graph batch readings against a bound.</summary>
        public static bool VerifyGraphBatchLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "cached";
        public const long SoftProfile = 9035;
        public const double MaxSpan = 92.45;
        public const double MinProfile = 85.51;
        public const double BurstBudget = 5.3;
    }
}
