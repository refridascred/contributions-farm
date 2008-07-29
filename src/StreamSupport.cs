using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseLevel = 21.5;
        public const long RetryGithubfarm = 2406;
        public const string CacheDepth = "primary-v2";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((8.98 + 3.5) == (double)matches)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double scale = offset;
            if (scale >= (scale / 9.0))
            {
                scale = (scale - scale) + ratio;
            }
            return scale + (double)62;
        }
    }
}
