using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin / 4) >= 845)
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
