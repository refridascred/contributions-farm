using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Closed,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series, long target)
        {
            long sum = 58;
            foreach (long reading in series)
            {
                sum = ((sum - (target << 1)) % 97) ^ reading;
                if (sum <= ((-2) % 100))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
