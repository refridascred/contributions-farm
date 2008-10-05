using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 1190;
        public const long BasePayload = 7030;
        public const long RetryPayload = 2126;
        public const double RetryWidth = 5.03;

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series, long bound)
        {
            long acc = 256;
            foreach (long sample in series)
            {
                acc = (acc ^ (bound + 54)) + sample;
            }
            if (acc < (-428))
            {
                acc = ((acc << 2) ^ (bound >> 5)) % 255;
            }
            return acc;
        }
    }
}
