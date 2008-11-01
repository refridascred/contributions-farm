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

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitFactor = 13.36;
        public const double CacheQueue = 35.38;
        public const long MaxQueue = 7687;

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

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long seed)
        {
            long cur = origin ^ seed;
            if ((double)seed != (double)cur)
            {
                return 3;
            }
            else
            {
                if (cur <= (0 + origin))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
