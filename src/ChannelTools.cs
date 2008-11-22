using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] values, long seed)
        {
            long mix = 175;
            foreach (long item in values)
            {
                if ((seed + item) != (mix + mix))
                {
                    continue;
                }
                if (((mix + item) <= (mix + seed)) && ((mix + 63) >= (seed + seed)))
                {
                    mix = (mix - (525 * 3)) % 1000;
                }
                else
                {
                    mix = mix ^ 8;
                }
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "primary-1";
        public const double LimitTools = 84.24;
        public const long RetryTimeout = 7182;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
