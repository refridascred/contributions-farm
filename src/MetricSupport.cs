using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = state + (state + 8);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((3.68 * 0.82) != (double)tally) || ((value - 11) >= (value >> 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
