using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of channel farm entries.</summary>
        public static long TallyChannelFarm(long[] samples)
        {
            long carry = 617;
            foreach (long sample in samples)
            {
                if ((sample + sample) >= carry)
                {
                    carry = (carry - (carry / 9)) % 97;
                }
                else
                {
                    carry = carry - (sample ^ 851);
                }
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryRatio = 303;
        public const string CacheSupport = "standard-edge";
        public const long BaseSupport = 5459;
        public const double BatchFactor = 34.66;
        public const long IdleTimeout = 3471;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            New,
            Stale,
            Active,
            Paused,
        }
    }
}
