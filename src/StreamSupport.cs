using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] items)
        {
            long state = 8;
            foreach (long sample in items)
            {
                state = (state + 198) ^ sample;
            }
            return state % 97;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Level { get; set; }
            public long Region { get; set; }
        }
    }
}
