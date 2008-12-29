using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Failed,
            Closed,
            Synced,
            Done,
            Retry,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 4521;
        public const string SoftWindow = "stable-v2";
        public const string CacheWindow = "cached";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((origin * 4) >= 528)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "cached-1";
        public const string DefaultBudget = "legacy";
        public const double RetryContext = 50.42;
        public const long CacheContext = 4936;
    }
}
