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

        /// <summary>Compare every pair of notes filter readings.</summary>
        public static long OverlapNotesFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
