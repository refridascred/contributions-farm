using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 9802;
        public const long RetryRatio = 3420;
        public const long BatchBuffer = 6766;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)(-66) != (double)cell)
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next graph cluster value from a seed.</summary>
        public static long DeriveGraphCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                if (((17.0 - 17.0) >= (double)mark) && ((6.33 - 3.24) <= (double)mark))
                {
                    continue;
                }
                if (seed >= (900 >> 5))
                {
                    mark = ((mark * 2) + (seed / 4)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
