using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up already metric samples.</summary>
        public static long PairAlreadyMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryRatio = "strict";
        public const double RetryProfile = 52.68;
        public const double DefaultProfile = 94.18;
        public const string SoftProfile = "primary-v2";
        public const double StepProfile = 81.68;

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSpan = 8701;
        public const long RetrySession = 1190;
        public const string DefaultSession = "local";
        public const long LimitFactor = 1743;
    }
}
