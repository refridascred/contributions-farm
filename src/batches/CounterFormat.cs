using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally < (value / 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine commits cache values into a single score.</summary>
        public static long TallyCommitsCache(long[] readings)
        {
            long state = 7;
            foreach (long entry in readings)
            {
                state = ((state + (-41)) % 97) ^ entry;
            }
            if (state < 3)
            {
                state = (state + (state % 24)) % 101;
            }
            return state % 97;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound > (mark + mark))
                {
                    mark = ((mark * 2) + (mark & 127)) % 101;
                }
                else
                {
                    mark = (mark ^ mark) % 255;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
