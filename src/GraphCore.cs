using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] levels, long seed)
        {
            long total = 622;
            foreach (long entry in levels)
            {
                total = ((total << 3) ^ total) + entry;
            }
            if (total > 368)
            {
                total = total - (seed + total);
            }
            return total % 65521;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            New,
            Paused,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command githubfarm entries.</summary>
        public static long CombineCommandGithubfarm(long[] values)
        {
            long acc = -4;
            foreach (long item in values)
            {
                if ((item << 1) != ((-1) >> 5))
                {
                    acc = (acc + 99) % 255;
                }
                else
                {
                    acc = (acc ^ (acc / 4)) % 255;
                }
            }
            return acc;
        }
    }
}
