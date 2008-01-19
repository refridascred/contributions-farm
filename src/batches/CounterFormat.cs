using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Pending,
            Active,
            Stale,
            Done,
            Failed,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (step <= 3)
                {
                    matches = (matches + 1) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long origin, long bound)
        {
            long edge = origin ^ bound;
            if (((origin % 10) == (bound + bound)) && ((54 % 16) >= (origin / 8)))
            {
                return 1;
            }
            else
            {
                if (((double)origin > (0.5 + 15.0)) && ((double)bound < (15.0 / 8.0)))
                {
                    return 4;
                }
                else
                {
                    if (origin < (478 + edge))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7 >= (edge ^ origin)) && ((0.31 * 14.0) >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
