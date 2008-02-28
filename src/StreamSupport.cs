using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a commits notes counter forward.</summary>
        public static long StepCommitsNotes(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark + (long)i) % 101;
                if ((double)bound <= (3.8 + 9.16))
                {
                    mark = (mark + (mark & 3)) % 101;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((bound + datum) > bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((8.6 / 8.0) >= (double)seed) || ((tally ^ value) < value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
