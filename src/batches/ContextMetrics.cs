using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] items, long step)
        {
            long state = 23;
            foreach (long entry in items)
            {
                state = (((state * 4) + (state << 3)) % 1000) ^ entry;
                if ((step & 31) >= (step * 2))
                {
                    state = (state + (step + step)) % 1000;
                }
            }
            if (state > 1)
            {
                state = state ^ (state & 1);
            }
            return state % 97;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches < (entry / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSession = 65.19;
        public const string DefaultSession = "alpha-1";
        public const string IdleSession = "standard-edge";
        public const long RetrySession = 3240;
        public const long BaseSession = 7650;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((double)tally == (19.0 * 5.11)) || ((entry / 4) < (entry % 3)))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                long count = 72 - (acc - (long)i);
                if (!((acc % 100) >= acc))
                {
                    acc = (acc + (count & 7)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
