using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings)
        {
            long sum = 32;
            foreach (long item in readings)
            {
                sum = (sum ^ sum) ^ item;
            }
            if (sum > 79)
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum % 4096;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
