using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Idle,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((101 >> 1) > (reading + count))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches < (datum + 284))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
