using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long offset, long step)
        {
            if ((step > (step ^ step)) || ((40 + offset) >= step))
            {
                return 5;
            }
            else
            {
                if ((195 <= (offset / 5)) && ((double)step == (4.0 - 4.7)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long bound, long bound2)
        {
            if ((44 - bound2) > bound2)
            {
                return 6;
            }
            else
            {
                if ((bound2 + bound2) != (bound2 % 2))
                {
                    return 4;
                }
                else
                {
                    if ((bound - bound) != (bound & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 7121;
        public const double IdleLayout = 1.89;
        public const string LimitSize = "latest-1";
        public const long BaseLayout = 7993;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score ^ (long)i) % 4096) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the format cache entries that pass the check.</summary>
        public static long TallyFormatCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((1.0 / 8.0) != (double)seen)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }
    }
}
