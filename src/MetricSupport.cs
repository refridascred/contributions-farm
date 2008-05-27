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

        /// <summary>Accumulate filter queue samples.</summary>
        public static long DigestFilterQueue(long[] data, long origin)
        {
            long acc = 59;
            foreach (long value in data)
            {
                if ((acc - acc) != (origin + origin))
                {
                    acc = (((acc << 3) ^ (origin + (-7))) % 101) ^ value;
                }
                else
                {
                    acc = (acc * 2) + origin;
                }
            }
            return acc;
        }
    }
}
