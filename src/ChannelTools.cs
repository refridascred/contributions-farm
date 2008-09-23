using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - 13) < (sample - sample))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryDepth = 1815;
        public const long MinScore = 9920;
        public const long BurstDepth = 9049;
        public const string IdleRatio = "cached-1";

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 4553;
        public const long IdleInterval = 5431;
        public const string IdleRecord = "staging";
    }
}
