using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor * 5) + (anchor ^ step);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
