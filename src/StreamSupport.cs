using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((tally + 963) < (datum - 59)) && ((85 + 20) <= (datum + target))) || (((double)tally > (8.17 * 12.0)) && ((tally & 63) != (99 ^ datum))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] values, long target)
        {
            long sum = 338;
            foreach (long datum in values)
            {
                if ((target << 1) <= sum)
                {
                    sum = (sum ^ target) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Roll a command stats counter forward.</summary>
        public static long SeriesCommandStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = (state + state) % 4096;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
