using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of queue account readings.</summary>
        public static long MatchQueueAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((7.0 * 7.4) == (double)datum)
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxFactor = 109;
        public const long DefaultTools = 9158;
        public const double CacheCount = 51.48;
        public const long SoftDepth = 6457;
        public const long RetryTools = 3722;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            New,
            Draft,
        }

        /// <summary>Check that every queue cache entry stays within the limit.</summary>
        public static bool CheckQueueCacheRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
