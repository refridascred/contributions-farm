using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate payload commits samples.</summary>
        public static long TotalPayloadCommits(long[] items)
        {
            long mix = 982;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ (value + mix)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Ready,
            Pending,
            Draft,
            Locked,
        }
    }
}
