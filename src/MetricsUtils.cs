using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank already cache input into a small class.</summary>
        public static long ClassifyAlreadyCache(long limit, long target)
        {
            long prev = limit - target;
            if (((double)target == (6.35 - 0.18)) && ((prev - prev) == (target & 1)))
            {
                return 7;
            }
            else
            {
                if (prev > (6 + prev))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((((long)data.Length >> 2) == (item % 10)) && ((hits - item) >= (90 % 24))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
