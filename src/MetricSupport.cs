using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) == (reading / 7))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((double)cell >= 18.0))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue command samples are out of range.</summary>
        public static long MeasureQueueCommandGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum * 2) >= (48 * 3))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }
    }
}
