using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftTimeout = 6917;
        public const long RetrySpan = 1930;
        public const double DefaultCount = 69.62;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples)
        {
            long carry = 539;
            foreach (long sample in samples)
            {
                carry = ((carry - (306 >> 4)) % 4096) - sample;
            }
            return carry % 4096;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Dropped,
            Queued,
            Synced,
            Stale,
        }
    }
}
