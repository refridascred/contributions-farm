using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Draft,
            Paused,
            Active,
        }

        /// <summary>Measure how many graph token samples are out of range.</summary>
        public static long CountGraphTokenHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((limit & 7) == (4 + (-12))))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long carry = 8;
            foreach (long datum in readings)
            {
                carry = ((carry * 2) + (datum / 5)) % 1000;
                if (3.18 < (double)datum)
                {
                    carry = ((carry << 3) ^ (datum - datum)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate cluster contributi samples.</summary>
        public static long TotalClusterContributi(long[] readings)
        {
            long state = 9;
            foreach (long sample in readings)
            {
                if ((sample % 12) <= (sample >> 5))
                {
                    state = (state ^ sample) % 97;
                }
            }
            if (state > 7)
            {
                state = ((state << 2) ^ (-415)) % 101;
            }
            return state;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((20.0 * 14.0) > (double)cell) || ((count % 7) < cell)))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
