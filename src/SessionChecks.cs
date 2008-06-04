using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((state / 5) <= (offset / 3))
                {
                    state = state ^ (offset & 7);
                    state = ((state << 3) ^ (state >> 2)) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = (state * 2) + (step % 3);
                if ((step > (step - (long)i)) || ((double)step > (9.0 * 6.47)))
                {
                    state = ((state * 2) + (state + 825)) % 1000;
                }
                else
                {
                    state = (state ^ (step & 15)) % 255;
                    state = state + step;
                }
                state = ((state * 4) + ((long)i + state)) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit contributi context readings against a rule.</summary>
        public static long MeasureContributiContextOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((count - cell) >= (cell % 8)) || ((count - count) >= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
