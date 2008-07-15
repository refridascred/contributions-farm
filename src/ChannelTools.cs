using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches - matches) < (value & 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Retry,
            Done,
            Closed,
        }
    }
}
