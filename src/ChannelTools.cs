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

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }
    }
}
