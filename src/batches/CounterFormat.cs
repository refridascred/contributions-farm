using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the counter session entries that pass the check.</summary>
        public static long CountCounterSessionHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((5 + hits) >= (hits / 3))
                {
                    hits = ((hits + 3) + datum) - bound;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel metric samples are out of range.</summary>
        public static long TallyChannelMetricHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading <= (tally % 3))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
