using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((3.0 + 14.0) < (double)count) && (count < (331 / 8)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi session entries.</summary>
        public static long TotalContributiSession(long[] data, long offset)
        {
            long carry = 4;
            foreach (long item in data)
            {
                carry = ((carry + ((-6) + offset)) % 4096) + item;
            }
            return carry;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Failed,
            Locked,
            Queued,
            Idle,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value * 5) <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Paused,
            Draft,
        }
    }
}
