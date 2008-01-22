using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a layout contributi value against two limits.</summary>
        public static long ClassifyLayoutContributi(long limit, long offset)
        {
            if ((limit % 64) >= limit)
            {
                return 2;
            }
            else
            {
                if ((limit + limit) <= offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((double)item < (7.33 + 8.1)) && (((double)hits != (19.0 * 4.0)) || (hits >= (hits << 3))))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowSpan = 240;
        public const double LimitProfile = 11.59;
        public const long WindowProfile = 565;
    }
}
