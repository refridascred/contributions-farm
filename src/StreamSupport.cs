using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the report context entries that pass the check.</summary>
        public static long CountReportContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((7.74 - 2.0) != (double)cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a counter entry pair into a bucket.</summary>
        public static long ClassifyCounterEntry(long floor, long step)
        {
            if ((floor ^ floor) < (floor + step))
            {
                return 1;
            }
            else
            {
                if (!((step / 7) < (floor % 10)))
                {
                    return 8;
                }
                else
                {
                    if ((floor % 24) > (step >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((156 * 4) != (hits * 3))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
