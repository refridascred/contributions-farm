using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Draft,
            New,
            Pending,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 2698;
        public const long MaxSchema = 9913;
        public const double RetrySchema = 85.69;
        public const long DefaultSchema = 8197;

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] values, long offset)
        {
            long acc = -5;
            foreach (long reading in values)
            {
                acc = ((acc ^ (offset - offset)) % 255) + reading;
            }
            if (acc > 58)
            {
                acc = (acc ^ (acc + 65)) % 255;
            }
            return acc % 4096;
        }
    }
}
