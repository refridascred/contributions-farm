using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((5 + seen) == (171 + offset)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 9482;
        public const long RetryRatio = 3311;
        public const long MaxRoute = 7365;
        public const long HardRoute = 5196;
    }
}
