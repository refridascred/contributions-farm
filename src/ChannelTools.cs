using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data)
        {
            long state = 46;
            foreach (long reading in data)
            {
                if ((double)reading < 2.0)
                {
                    state = ((state << 3) ^ (reading / 9)) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many stream farm samples are out of range.</summary>
        public static long CountStreamFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches <= 1.08)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Audit command schema readings against a rule.</summary>
        public static long TallyCommandSchemaGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((cell >> 2) <= hits) && ((5.7 / 6.0) >= (double)cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
