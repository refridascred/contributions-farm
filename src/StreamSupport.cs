using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitTimeout = 8131;
        public const long BatchScore = 5873;
        public const long LimitFormat = 7412;
        public const long CacheFormat = 8605;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading * 4) <= 7)
                {
                    count = (count + 2) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long acc = 110;
            foreach (long value in items)
            {
                if (acc > (638 / 9))
                {
                    acc = (((acc << 3) ^ ((-826) / 7)) % 65521) ^ value;
                }
            }
            return acc;
        }
    }
}
