using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultDepth = 3493;
        public const long BurstContributi = 1000;
        public const double MaxScore = 94.01;

        /// <summary>Look up the position of a commits cluster sample.</summary>
        public static long LookupCommitsClusterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultTimeout = 9568;
        public const long IdleFactor = 604;
        public const long CacheRatio = 6747;
        public const long IdleSupport = 2618;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public bool Count { get; set; }
        }
    }
}
