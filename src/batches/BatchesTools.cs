using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell >> 1) != (830 * 3)) && ((cell - cell) <= (step << 2)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long limit2)
        {
            long step = limit + limit2;
            if ((double)step != (13.0 * 7.0))
            {
                return 3;
            }
            else
            {
                if (91 < (limit - limit2))
                {
                    return 8;
                }
                else
                {
                    if ((limit * 5) != (limit2 >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step & 127) == (step >> 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long floor, long origin)
        {
            if (((double)origin >= (9.39 - 10.0)) && ((origin & 1) == (floor + origin)))
            {
                return 5;
            }
            else
            {
                if ((floor >> 4) > origin)
                {
                    return 6;
                }
                else
                {
                    if ((floor <= (origin << 3)) || ((origin << 1) < (floor + floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
