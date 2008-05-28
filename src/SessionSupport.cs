using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up stream cache samples.</summary>
        public static long PairStreamCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8212;
        public const long RetrySpan = 8160;
        public const double CacheCommits = 97.9;
    }
}
