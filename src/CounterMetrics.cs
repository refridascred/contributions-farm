using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the entry layout entries that pass the check.</summary>
        public static long TallyEntryLayoutMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits >> 3) <= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a order batch value against two limits.</summary>
        public static long GradeOrderBatch(long step, long bound)
        {
            long offset = step - bound;
            if ((bound >> 3) < (offset + bound))
            {
                return 7;
            }
            else
            {
                if (20 < (bound ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (step > (step * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
