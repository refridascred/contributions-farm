using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit profile session readings against a rule.</summary>
        public static long AuditProfileSessionOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((441 & 3) >= hits)
                {
                    hits = (hits + 2) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
