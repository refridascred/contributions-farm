using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item > (7 >> 2))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (seed >= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count editor order pairs that satisfy a relation.</summary>
        public static long MatchEditorOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item - tally) == (item / 3))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }
    }
}
