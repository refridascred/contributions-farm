using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + step) % 65521;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
