using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] samples, long limit)
        {
            long state = 65;
            foreach (long item in samples)
            {
                if ((double)item <= (double)838)
                {
                    state = ((state << 2) ^ (item - 35)) - limit;
                }
            }
            return state;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] levels)
        {
            long mark = 595;
            foreach (long item in levels)
            {
                mark = (((mark * 5) + (mark % 64)) % 1000) + item;
            }
            if (mark < 271)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample - seed) <= (matches ^ seed)) || (((double)sample != (double)matches) || ((seed & 3) >= seed)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
