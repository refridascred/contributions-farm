using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
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

        /// <summary>Derive the next context profile value from a seed.</summary>
        public static long SeriesContextProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                if (682 <= (limit / 9))
                {
                    result = (result ^ (limit << 2)) % 65521;
                }
                result = ((result << 3) ^ ((long)i >> 1)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
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
