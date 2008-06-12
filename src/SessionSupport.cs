using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate route githubfarm samples.</summary>
        public static long DigestRouteGithubfarm(long[] values)
        {
            long mark = 178;
            foreach (long value in values)
            {
                mark = mark ^ (mark >> 4);
                if ((value / 4) > mark)
                {
                    mark = (mark - (mark & 127)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
