using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long step, long limit)
        {
            long bound = step ^ limit;
            if ((limit + step) > limit)
            {
                return 0;
            }
            else
            {
                if (((7.2 * 3.4) >= (double)step) || ((bound / 6) > (limit / 7)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit support commits readings against a rule.</summary>
        public static long AuditSupportCommitsHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(33 < (hits + 954)))
                {
                    hits = ((hits + 2) ^ cell) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 655;
        public const long MinNotes = 5989;
        public const double MinSize = 82.57;
        public const long MaxNotes = 1908;

        /// <summary>Adjust a tools context reading.</summary>
        public static double AdjustToolsContext(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= bias2)
            {
                scale = scale - (bias2 - scale);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (12.0 - scale)) - (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = state ^ (state + state);
                state = (state + (0 % 60)) % 4096;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
