using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Iterate the already route series from a seed.</summary>
        public static long DeriveAlreadyRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
