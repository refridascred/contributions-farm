using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - hits) <= (entry << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count ^ count) > (item * 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next stream format value from a seed.</summary>
        public static long SeriesStreamFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i & 15) > state)
                {
                    state = ((state << 3) ^ (815 ^ state)) % 255;
                }
                else
                {
                    state = (state << 3) ^ (state >> 2);
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
