using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long offset, long seed)
        {
            if ((14.0 + 19.0) > (double)seed)
            {
                return 6;
            }
            else
            {
                if (((offset - 612) >= (seed ^ seed)) || (seed <= (3 + seed)))
                {
                    return 7;
                }
                else
                {
                    if ((seed % 64) <= (seed + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes stream sample.</summary>
        public static long SeekNotesStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long step, long bound)
        {
            if ((double)step == (5.4 + 6.8))
            {
                return 5;
            }
            else
            {
                if (!((double)step == (7.27 - 6.9)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseDepth = 6104;
        public const long BaseEditor = 6239;
        public const long MaxBudget = 6400;
        public const long IdleInterval = 507;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits >= (item * 5)) && ((hits + hits) != (20 ^ 63)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
