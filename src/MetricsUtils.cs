using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up editor session samples.</summary>
        public static long OverlapEditorSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a context command counter forward.</summary>
        public static long SeriesContextCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((seed + seed) == (seed >> 2))
                {
                    mark = mark - ((long)i * 3);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry >> 5) > entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] values)
        {
            long state = 7;
            foreach (long cell in values)
            {
                state = state - (cell % 64);
                state = state + (state * 5);
                if (!((double)state == (0.41 + 5.0)))
                {
                    state = state - state;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen <= floor)
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
