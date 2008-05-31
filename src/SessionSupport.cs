using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long seed, long bound)
        {
            long step = seed - bound;
            if (((step - seed) != (bound * 4)) || ((seed >> 5) <= (bound + seed)))
            {
                return 1;
            }
            else
            {
                if ((double)step > (1.2 / 8.0))
                {
                    return 8;
                }
                else
                {
                    if ((seed * 4) <= (7 + 528))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine notes order values into a single score.</summary>
        public static long ScoreNotesOrder(long[] items, long target)
        {
            long result = 854;
            foreach (long cell in items)
            {
                result = ((result + (target >> 2)) % 1000) ^ cell;
            }
            if (result < 4)
            {
                result = result - (36 * 5);
            }
            return result % 97;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (anchor % 12)) % 101;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
