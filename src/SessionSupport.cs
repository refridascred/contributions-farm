using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many layout record samples are out of range.</summary>
        public static long CountLayoutRecordMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item == (6.9 * 18.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - reading) != (limit - 49))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((5.7 + 4.52) <= (double)matches) && ((matches % 24) < (5 + 155)))
                {
                    matches = ((matches + 3) + item) - seed;
                }
            }
            return matches;
        }
    }
}
