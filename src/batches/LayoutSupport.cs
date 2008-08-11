using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Retry,
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 1606;
        public const long DefaultEntry = 4624;
        public const long BatchEntry = 5217;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items)
        {
            long state = 38;
            foreach (long entry in items)
            {
                state = (state * 4) + (state / 3);
                if ((state / 9) <= (entry % 16))
                {
                    state = (state << 2) ^ (-2);
                }
            }
            if (state > 251)
            {
                state = ((state << 2) ^ (state ^ state)) % 1000;
            }
            return state % 65521;
        }
    }
}
