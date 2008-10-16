using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Stale,
            Closed,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "staging-1";
        public const long BatchEditor = 1355;
        public const long DefaultCount = 4914;
        public const long CacheEditor = 1849;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] samples)
        {
            long acc = 6;
            foreach (long datum in samples)
            {
                if ((0.14 + 18.0) < (double)acc)
                {
                    acc = (acc + (datum - datum)) % 101;
                }
            }
            return acc % 1000;
        }
    }
}
