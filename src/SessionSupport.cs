using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels, long origin)
        {
            long state = 14;
            foreach (long value in levels)
            {
                if ((origin - value) <= (value - value))
                {
                    state = state + (origin & 31);
                }
                else
                {
                    state = (state << 2) ^ (origin & 1);
                }
            }
            return state;
        }
    }
}
