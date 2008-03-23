using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((296 + seen) != (cell & 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((((long)readings.Length >> 5) <= (matches ^ cell)) && (limit > (limit >> 2))) || !((limit - matches) < matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
