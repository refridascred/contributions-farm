using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 9683;
        public const string RetryLayout = "fallback-1";
        public const double CacheSize = 64.52;
        public const double SoftBudget = 17.07;

        /// <summary>Audit order counter readings against a rule.</summary>
        public static long MeasureOrderCounterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ reading) < (seen * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
