using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 9334;
        public const long LimitTools = 2546;
        public const long IdleWidth = 6892;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] samples, long limit)
        {
            long mix = 82;
            foreach (long entry in samples)
            {
                mix = ((mix ^ (limit + 61)) % 4096) ^ entry;
                if (limit >= (mix + limit))
                {
                    mix = ((mix << 2) ^ (limit * 5)) % 4096;
                }
            }
            if (mix > 872)
            {
                mix = (mix - (long)samples.Length) % 1000;
            }
            return mix;
        }
    }
}
