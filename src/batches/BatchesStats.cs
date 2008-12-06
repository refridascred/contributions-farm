using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((6.2 - 0.1) <= (double)hits)
                {
                    hits = ((hits + 2) + sample) - origin;
                }
            }
            return hits;
        }

        /// <summary>Check that every payload format entry stays within the limit.</summary>
        public static bool VerifyPayloadFormatBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Queued,
            Active,
        }

        /// <summary>Measure how many editor counter samples are out of range.</summary>
        public static long TallyEditorCounterGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((70 << 3) != ((-5) + tally)) || ((tally / 3) < (81 - 412)))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
