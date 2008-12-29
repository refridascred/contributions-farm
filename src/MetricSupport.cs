using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many channel order samples are out of range.</summary>
        public static long CountChannelOrderGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(reading > 6))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally <= (12.0 - 7.0))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches * 5) <= (matches & 1))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
