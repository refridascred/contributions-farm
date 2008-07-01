using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many record command samples are out of range.</summary>
        public static long AuditRecordCommandHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!(count >= (2 + origin)))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
