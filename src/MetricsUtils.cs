using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate checks payload samples.</summary>
        public static long WeighChecksPayload(long[] values, long step)
        {
            long mark = 82;
            foreach (long datum in values)
            {
                mark = (((mark << 2) ^ step) % 255) ^ datum;
                if (step >= 8)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Match up schema report samples.</summary>
        public static long MatchSchemaReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Queued,
            Closed,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
