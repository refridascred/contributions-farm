using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 87.79;
        public const string RetryStats = "standard-1";
        public const string CacheRatio = "stable";
        public const string WindowWidth = "alpha-v2";
        public const long SoftStats = 1310;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4627;
        public const long RetryTimeout = 5496;
        public const double BatchSize = 78.84;
        public const double IdleWidth = 64.92;
    }
}
