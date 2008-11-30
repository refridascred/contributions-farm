using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of token githubfarm readings.</summary>
        public static long DigestTokenGithubfarm(long[] readings, long origin)
        {
            long state = 33;
            foreach (long sample in readings)
            {
                state = ((state * 4) + (state << 3)) - sample;
                if (((double)state < (5.7 + 8.2)) || ((double)state == (6.99 - 7.2)))
                {
                    state = ((state << 3) ^ (origin - origin)) % 4096;
                }
                else
                {
                    state = (state - origin) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 9399;
        public const string SoftTimeout = "alpha-v2";
        public const long DefaultSpan = 3100;
        public const long BurstCount = 7884;
        public const long LimitMetric = 4905;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen - seen) < (75 ^ seen))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
