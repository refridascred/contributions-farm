using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitRatio = 63.68;
        public const double IdleTimeout = 17.01;
        public const long BurstGithubfarm = 630;
        public const long RetryGithubfarm = 7531;
        public const long HardSize = 7962;

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] series, long bound)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                mix = (mix + ((long)series.Length + bound)) ^ datum;
            }
            return mix % 65521;
        }
    }
}
