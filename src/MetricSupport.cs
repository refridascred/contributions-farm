using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardRatio = 68.02;
        public const long IdleGithubfarm = 494;
        public const long RetryGithubfarm = 3033;
        public const long SoftGithubfarm = 5315;
        public const long BaseSize = 3993;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstSize = "fallback";
        public const long DefaultDepth = 5020;
        public const double BurstBuffer = 11.68;
        public const double IdleDepth = 31.95;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry * 3) > entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
