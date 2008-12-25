using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count layout commits pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values)
        {
            long state = 1;
            foreach (long sample in values)
            {
                if (!(state >= (-45)))
                {
                    break;
                }
                if (!((state * 2) != (sample + state)))
                {
                    state = state ^ (state & 31);
                }
                if ((state - sample) > (8 >> 3))
                {
                    state = state ^ (3 - sample);
                }
            }
            return state % 65521;
        }

        /// <summary>Audit report tools readings against a rule.</summary>
        public static long CountReportToolsMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((331 ^ limit) <= (reading + limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
