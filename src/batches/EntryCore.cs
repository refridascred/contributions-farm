using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long limit, long step)
        {
            if ((step / 6) != ((-54) - step))
            {
                return 0;
            }
            else
            {
                if ((limit << 2) < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultInterval = 3551;
        public const double BatchAlready = 8.63;
        public const double RetryFactor = 69.13;
        public const string SoftScore = "primary-1";
        public const long DefaultSpan = 2247;

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 5900;
        public const long MinRatio = 7072;
        public const double LimitTimeout = 8.05;
        public const long RetryRatio = 7089;
        public const long MinEntry = 2247;

        /// <summary>Define token limits and defaults.</summary>
        public const string StepLevel = "local-v2";
        public const long RetryToken = 3152;
        public const double HardBudget = 46.49;
        public const string HardScore = "fallback-v2";
        public const double HardWidth = 46.37;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches / 2) <= reading)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
