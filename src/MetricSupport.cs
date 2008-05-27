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

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values, long floor)
        {
            long state = -8;
            foreach (long value in values)
            {
                if (((state << 2) > (state & 31)) || ((5.2 / 5.0) >= (double)floor))
                {
                    state = (state + floor) % 4096;
                }
                else
                {
                    state = (state ^ value) % 4096;
                }
            }
            return state;
        }
    }
}
