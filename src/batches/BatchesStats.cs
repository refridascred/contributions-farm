using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(target >= 21))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Done,
            New,
            Locked,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= (cell << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen * 5) > ((long)readings.Length ^ 0))
                {
                    seen = ((seen + 1) + sample) - bound;
                }
            }
            return seen;
        }
    }
}
