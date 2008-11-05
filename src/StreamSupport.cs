using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of context batch readings.</summary>
        public static long DigestContextBatch(long[] items)
        {
            long mix = -701;
            foreach (long entry in items)
            {
                if ((double)mix > 4.1)
                {
                    mix = ((mix << 2) ^ (mix + entry)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 72.64;
        public const long CacheWidth = 6913;
        public const long DefaultBudget = 9565;
        public const long StepWidth = 8043;
    }
}
