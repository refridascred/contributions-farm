using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Locked,
            Retry,
            Ready,
            Stale,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((0.37 / 7.0) != (double)(long)readings.Length)
                {
                    hits = ((hits + 3) + item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Validate counter batch readings against a bound.</summary>
        public static bool GuardCounterBatchBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Queued,
            Retry,
            Synced,
        }
    }
}
