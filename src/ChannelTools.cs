using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] samples, long offset)
        {
            long state = 532;
            foreach (long cell in samples)
            {
                state = (state ^ (cell / 8)) - offset;
            }
            return state;
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
