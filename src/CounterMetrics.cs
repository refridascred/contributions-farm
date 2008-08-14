using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first account graph entry that matches the target.</summary>
        public static long LookupAccountGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!!((double)step != (1.54 - 1.0)))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] data)
        {
            long mix = 611;
            foreach (long value in data)
            {
                if (!((double)mix == (1.0 - 0.03)))
                {
                    mix = (mix << 2) ^ value;
                }
                if ((value ^ mix) >= 3)
                {
                    mix = (mix - (mix + mix)) % 4096;
                }
            }
            return mix;
        }
    }
}
