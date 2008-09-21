using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4248;
        public const long MinWidth = 3207;
        public const long MinDepth = 2722;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((double)offset <= (9.7 / 5.0)) || !((sample & 1) != (266 ^ offset)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 >= ratio2)
            {
                ratio2 = ratio2 - (double)412;
            }
            else
            {
                ratio2 = ratio2 - (6.7 - ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 + (ratio / 6.0);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values, long bound)
        {
            long state = 38;
            foreach (long datum in values)
            {
                state = state + (datum << 1);
                if (!(bound >= (bound - datum)))
                {
                    state = (state - (228 - state)) % 101;
                }
            }
            if (state > 8)
            {
                state = (state + (bound % 100)) % 4096;
            }
            return state % 97;
        }
    }
}
