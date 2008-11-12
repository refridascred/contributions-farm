using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long origin, long target)
        {
            if (((target + target) < target) && ((double)origin < 9.0))
            {
                return 0;
            }
            else
            {
                if ((18.0 > (double)target) && (target < (origin - 86)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleLevel = 31.2;
        public const long MinGithubfarm = 7485;
        public const double CacheDepth = 79.69;
        public const long BatchGithubfarm = 2717;
        public const double SoftFactor = 82.36;
    }
}
