using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 92.49;
        public const long CacheToken = 9855;
        public const long IdleInterval = 3448;
        public const long BurstScore = 3316;

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] levels)
        {
            long anchor = 382;
            foreach (long entry in levels)
            {
                anchor = (anchor * 3) + (entry + entry);
            }
            return anchor % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 81.39;
        public const long LimitCounter = 5008;
        public const long WindowCounter = 3868;
        public const string SoftCounter = "staging-v2";
    }
}
