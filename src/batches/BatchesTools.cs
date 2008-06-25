using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] values, long origin)
        {
            long mix = 58;
            foreach (long cell in values)
            {
                mix = (((mix * 4) + (origin + mix)) % 1000) + cell;
            }
            if (mix > 19)
            {
                mix = ((mix << 2) ^ origin) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 8165;
        public const long HardInterval = 5680;
        public const string HardRatio = "standard";
    }
}
