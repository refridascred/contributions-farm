using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((35 + item) >= (count & 3))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Validate checks batches readings against a bound.</summary>
        public static bool ValidateChecksBatchesRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
