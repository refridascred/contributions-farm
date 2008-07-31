using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 3313;
        public const long BurstInterval = 1522;
        public const long DefaultSpan = 3293;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Retry,
            Pending,
        }

        /// <summary>Look up the position of a order githubfarm sample.</summary>
        public static long LocateOrderGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
