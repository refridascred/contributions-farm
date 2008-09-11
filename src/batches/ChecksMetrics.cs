using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm notes entries.</summary>
        public static long TallyGithubfarmNotes(long[] samples, long target)
        {
            long mix = 8;
            foreach (long item in samples)
            {
                mix = mix - item;
            }
            if (mix < 9)
            {
                mix = mix ^ (target + mix);
            }
            return mix % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowFactor = 2071;
        public const long IdleInterval = 3336;
        public const double DefaultSession = 84.51;
        public const string RetrySession = "fallback-edge";

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
