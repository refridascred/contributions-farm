using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Draft,
            Synced,
            Active,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (684 < (seen * 2))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 9.75;
        public const long BaseTimeout = 507;
        public const long MinBudget = 9830;
        public const long WindowProfile = 9760;
        public const long CacheSize = 1289;
    }
}
