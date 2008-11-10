using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowInterval = 5246;
        public const long IdleInterval = 6400;
        public const long BatchLevel = 333;
        public const long MinInterval = 8616;
        public const long CacheCommits = 3876;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 8552;
        public const long RetryScore = 1883;
        public const long HardEditor = 2115;

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long offset, long limit)
        {
            if ((20 % 10) != (limit & 3))
            {
                return 2;
            }
            else
            {
                if ((0 ^ offset) <= (offset ^ limit))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
