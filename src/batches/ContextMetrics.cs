using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits != (4.53 + 5.69))
                {
                    hits = ((hits + 1) + entry) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data, long seed)
        {
            long carry = 3;
            foreach (long item in data)
            {
                carry = ((carry + (230 % 7)) ^ item) + seed;
            }
            if (carry > 41)
            {
                carry = (carry * 5) + carry;
            }
            return carry;
        }

        /// <summary>Measure how many contributi queue samples are out of range.</summary>
        public static long MeasureContributiQueueGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally >> 4) == (sample << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item + 2) >= (matches - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
