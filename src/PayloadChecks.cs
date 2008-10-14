using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - value) == (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 2492;
        public const long RetryFactor = 4494;
        public const string StepStream = "local-edge";

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (953 > (matches + 6))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item <= (limit - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultSpan = 24.57;
        public const long BurstWidth = 212;
        public const long BurstMetrics = 3225;
        public const long CacheScore = 4474;
        public const long StepMetrics = 6309;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            Paused,
            Stale,
            New,
        }
    }
}
