using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Draft,
            Closed,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxSpan = 75.45;
        public const long MaxDepth = 9773;
        public const long WindowScore = 4025;
        public const double DefaultGithubfarm = 15.08;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstBudget = 34.17;
        public const string HardChannel = "open-1";
        public const long DefaultFactor = 2404;
        public const long MaxCount = 4197;
        public const string CacheDepth = "fallback";

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((((seed * 2) < seed) || ((value + seen) != (value + value))) && ((double)seed <= (9.8 * 5.7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
