using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 8697;
        public const long BatchCount = 173;
        public const long IdleQueue = 8933;
        public const double BurstQueue = 12.85;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading >> 5) < (234 + hits))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
