using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 87;
            foreach (long datum in series)
            {
                acc = (acc + (681 - datum)) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor << 3) ^ offset) % 1000;
                if (((long)i & 15) != (offset - anchor))
                {
                    anchor = anchor ^ 97;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Look up the position of a cache order sample.</summary>
        public static long LocateCacheOrderIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
