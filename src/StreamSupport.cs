using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data, long floor)
        {
            long mix = 511;
            foreach (long entry in data)
            {
                if ((floor << 2) > (floor - entry))
                {
                    mix = (mix << 2) ^ (floor ^ (long)data.Length);
                }
            }
            return mix;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long seed)
        {
            long acc = 59;
            foreach (long item in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (((acc << 3) ^ (acc / 5)) % 101) + (long)i;
                    acc = (acc * 4) + item;
                }
                if ((item / 4) > (seed - 505))
                {
                    acc = acc - 0;
                }
                else
                {
                    acc = ((acc << 2) ^ (seed & 31)) % 4096;
                }
            }
            return acc;
        }
    }
}
