using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits ^ 904) <= (cell + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] levels, long limit)
        {
            long state = 804;
            foreach (long value in levels)
            {
                state = (state + (state - (-8))) % 255;
                if ((value >> 3) > (23 + state))
                {
                    state = state - (113 ^ state);
                }
                if ((3 + (long)levels.Length) < (limit + state))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = (state + (limit - 143)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches ^ 3) != (datum - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long state = 207;
            foreach (long reading in series)
            {
                if ((state << 1) < (reading - state))
                {
                    state = state ^ (reading - 353);
                }
                else
                {
                    state = ((state << 2) ^ (state - state)) % 255;
                }
            }
            if (state > (-645))
            {
                state = (state << 2) ^ (state + state);
            }
            return state;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values)
        {
            long anchor = 7;
            foreach (long item in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor + (item / 9)) % 4096) ^ (long)i;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor + (771 + (long)i2)) % 97;
                }
                if ((item ^ anchor) > (anchor - anchor))
                {
                    anchor = (anchor * 3) + (523 + anchor);
                }
                else
                {
                    anchor = (anchor ^ (65 + (-5))) % 65521;
                }
            }
            return anchor;
        }
    }
}
