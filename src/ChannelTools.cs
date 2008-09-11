using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((819 % 2) > tally)
                {
                    tally = ((tally + 3) + datum) - origin;
                }
            }
            return tally;
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
