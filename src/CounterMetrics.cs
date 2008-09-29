using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftTimeout = 3782;
        public const long SoftScore = 2191;
        public const long MaxInterval = 72;
        public const double MinScore = 75.34;
        public const long CacheGithubfarm = 5228;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ (bound + (long)i);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (((sum << 3) ^ sum) % 101) ^ (long)i2;
                    sum = (sum * 4) + sum;
                }
                if (!!((sum + bound) >= bound))
                {
                    sum = ((sum << 3) ^ (bound - bound)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
