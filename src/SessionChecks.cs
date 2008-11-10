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
        public static long BucketContext(long target, long bound)
        {
            long slot = target - bound;
            if (!((slot & 7) != (bound - bound)))
            {
                return 6;
            }
            else
            {
                if (7 < bound)
                {
                    return 5;
                }
                else
                {
                    if ((target * 3) < (-1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target >= (target + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
