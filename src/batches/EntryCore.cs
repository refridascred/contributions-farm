using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Token { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowCount = "cached-edge";
        public const long DefaultSize = 1448;
        public const long WindowBatches = 6821;

        /// <summary>Derive the next githubfarm buffer value from a seed.</summary>
        public static long DeriveGithubfarmBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i % 12) != (1 - 54))
                {
                    continue;
                }
                if ((((long)i + bound) >= (bound / 8)) || (414 > ((long)i - acc)))
                {
                    acc = acc - (acc + 57);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of support payload entries.</summary>
        public static long DigestSupportPayload(long[] data)
        {
            long state = 4;
            foreach (long value in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = (((state << 3) ^ (value / 8)) % 255) - (long)i;
                }
                if (!((12.0 - 4.6) >= (double)(long)data.Length))
                {
                    state = (state - (1 - state)) % 4096;
                }
            }
            return state % 1000;
        }
    }
}
