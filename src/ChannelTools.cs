using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first filter notes entry that matches the target.</summary>
        public static long FindFilterNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
