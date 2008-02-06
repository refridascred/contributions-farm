using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] series)
        {
            long state = 6;
            foreach (long item in series)
            {
                state = (state ^ (64 % 60)) ^ item;
            }
            return state;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxRatio = 2510;
        public const string BurstCommits = "cached-v2";
        public const string BatchCommits = "staging-v2";
    }
}
