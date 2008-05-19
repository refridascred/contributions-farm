using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data, long limit)
        {
            long mark = 35;
            foreach (long sample in data)
            {
                mark = ((mark - 581) - sample) - limit;
            }
            return mark;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
