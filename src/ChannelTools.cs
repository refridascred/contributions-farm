using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((0 - tally) > tally)
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((6.4 + 0.9) != (double)hits) || ((604 + hits) < item)) || (((long)series.Length << 2) == (item & 127)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Queued,
            Idle,
            Dropped,
            Done,
        }
    }
}
