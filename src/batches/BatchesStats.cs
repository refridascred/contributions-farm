using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long acc = 388;
            foreach (long item in values)
            {
                if ((item << 2) <= (acc * 4))
                {
                    acc = (acc ^ (acc - item)) % 4096;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 8137;
        public const long MinChannel = 6819;
        public const long MinSize = 4365;
        public const long BaseChannel = 4207;
        public const long BurstTimeout = 8117;
    }
}
